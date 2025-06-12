using UnityEngine;
using UnityEngine.Events;
using Sirenix.OdinInspector;
using DG.Tweening;
using KayphoonStudio;

public class Owdi : MonoBehaviour
{
    [FoldoutGroup("Detection Settings")]
    [Tooltip("Range at which monster starts pursuing bike")]
    public float bikeEnterRange = 10f;
    
    [FoldoutGroup("Detection Settings")]
    [Tooltip("Range at which monster stops pursuing bike")]
    public float bikeExitRange = 15f;
    
    [FoldoutGroup("Movement Settings")]
    [Tooltip("Movement speed of the monster")]
    public float moveSpeed = 5f;
    
    [FoldoutGroup("Events")]
    public UnityEvent onBikeCollision;

    [FoldoutGroup("References")]
    [Required]
    [Tooltip("The visual representation of the monster")]
    public GameObject gfx;

    [FoldoutGroup("Movement Settings")]
    [Tooltip("Initial facing direction (1 for right, -1 for left)")]
    public float initialDirection = 1f;

    [FoldoutGroup("Detection Settings")]
    [Tooltip("Range at which monster hits the bike")]
    public float hitRange = 1f;

    [FoldoutGroup("Wandering Settings")]
    [Tooltip("Maximum distance the monster will wander from its current position")]
    public float wanderRadius = 5f;

    [FoldoutGroup("Wandering Settings")]
    [Tooltip("Time taken to move to next random position")]
    public float wanderMoveDuration = 2f;

    [FoldoutGroup("Wandering Settings")]
    [Tooltip("Time to wait before moving to next position")]
    [MinValue(0)]
    public float wanderWaitDuration = 1f;

    [FoldoutGroup("Wandering Settings")]
    [Tooltip("Easing function for wandering movement")]
    public Ease wanderEase = Ease.InOutSine;

    private Transform targetBike;
    private bool isPursuing;
    [SerializeField]
    private bool hasHit = false;  // New flag to track if hit has occurred
    private Vector3 startPosition;
    private Tween wanderTween;
    private bool isWandering;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = transform.position;
        // Set initial scale based on direction
        UpdateFacingDirection(initialDirection);
        StartWandering();

        // stop when a owdi already hits
        KS_NotificationCenter.AddEventListener(NKeys.OnOwdiSacrificeStart, () => {enabled = false;});
        KS_NotificationCenter.AddEventListener(NKeys.OnOwdiSacrificeEnd, () => {enabled = true;});
    }

    // Update is called once per frame
    void Update()
    {
        // First, check if we should start pursuing a bike
        if (!isPursuing && !hasHit)
        {
            FindNearestBike();  // Add this line to actively look for bikes
        }

        if (isPursuing && targetBike != null && !hasHit)
        {
            // Stop wandering when pursuing
            if (wanderTween != null)
            {
                wanderTween.Kill();
                isWandering = false;
            }

            // Calculate distance to current target
            float distanceToTarget = Vector3.Distance(transform.position, targetBike.position);
            
            // Check for hit
            if (distanceToTarget <= hitRange)
            {
                onBikeCollision?.Invoke();
                hasHit = true;  // Set the flag
                StopPursuit();
                return; // expect this script to be destroyed after this
            }
            
            // Stop pursuing if outside exit range
            if (distanceToTarget > bikeExitRange)
            {
                StopPursuit();
                return;
            }

            // Move towards target
            Vector3 direction = (targetBike.position - transform.position).normalized;
            // Keep y position constant
            direction.y = 0;
            transform.position += direction * moveSpeed * Time.deltaTime;

            // Update facing direction based on movement
            UpdateFacingDirection(direction.x);
        }
        else if (!isWandering && !hasHit)
        {
            StartWandering();
        }
    }

    private void FindNearestBike()
    {
        if (!enabled) return;

        Collider[] colliders = Physics.OverlapSphere(transform.position, bikeEnterRange);
        float nearestDistance = float.MaxValue;
        Transform nearestBike = null;

        foreach (Collider collider in colliders)
        {
            if (collider.CompareTag("Bike"))
            {
                float distance = Vector3.Distance(transform.position, collider.transform.position);
                if (distance < nearestDistance)
                {
                    nearestDistance = distance;
                    nearestBike = collider.transform;
                }
            }
        }

        if (nearestBike != null)
        {
            targetBike = nearestBike;
            isPursuing = true;
        }
    }

    private void StopPursuit()
    {
        targetBike = null;
        isPursuing = false;
        // Start wandering again after stopping pursuit (unless hit)
        if (!hasHit)
        {
            StartWandering();
        }
    }

    private void StartWandering()
    {
        isWandering = true;
        MoveToRandomPosition();
    }

    private void MoveToRandomPosition()
    {
        if (hasHit) return;

        // Get random point within wanderRadius
        Vector2 randomCircle = Random.insideUnitCircle * wanderRadius;
        Vector3 randomPosition = startPosition + new Vector3(randomCircle.x, 0, randomCircle.y);

        // Update facing direction based on movement direction
        UpdateFacingDirection(randomPosition.x - transform.position.x);

        // Create sequence for move and wait
        wanderTween = DOTween.Sequence()
            .Append(transform.DOMove(randomPosition, wanderMoveDuration)
                .SetEase(wanderEase))
            .AppendInterval(wanderWaitDuration)
            .OnComplete(() => {
                isWandering = false;
                // This will trigger the next random movement in Update
            });
    }

    private void OnDestroy()
    {
        // Clean up DOTween
        wanderTween?.Kill();
    }

    private void OnDrawGizmos()
    {
        // Draw enter range
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, bikeEnterRange);
        
        // Draw exit range
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, bikeExitRange);

        // Draw hit range
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, hitRange);

        // Draw wander radius
        if (Application.isPlaying)
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawWireSphere(startPosition, wanderRadius);
        }
    }

    private void UpdateFacingDirection(float directionX)
    {
        if (gfx != null)
        {
            Vector3 scale = gfx.transform.localScale;
            scale.x = Mathf.Abs(scale.x) * (directionX >= 0 ? 1 : -1);
            gfx.transform.localScale = scale;
        }
    }
}
