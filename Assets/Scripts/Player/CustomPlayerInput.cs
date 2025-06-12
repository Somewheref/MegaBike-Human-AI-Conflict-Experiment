using UnityEngine;
using UnityEngine.InputSystem;

using Obvious.Soap;
using UnityEngine.UI;

public class CustomPlayerInput : InputBase
{
    public LayerMask groundLayerMask;
    public FloatVariable strengthVariable;
    public float smallStrengthThreshold = 0.1f;

    protected PlayerInputConfig inputConfig;
    private PlayerInput playerInput;
    private InputAction movementAction;
    private InputAction strengthAction;
    private InputAction movementConfirmedAction;
    private bool isKeyboardMouseScheme;

    // cache for raycaster
    private GraphicRaycaster raycaster;

    [Header("version 4")]
    [SerializeField] private float mousePositionToStrengthMultiplier = 0.1f;

    [SerializeField] private float strengthChangeSpeed = 1f;
    [SerializeField] private float minStrength = 0f;
    [SerializeField] private float maxStrength = 1f;

    public float singlePressCD = 1.5f;
    private float singlePressTimer = 0f;
    private bool forceApplied = false;

    private int inputVersion = 4;


    void Awake()
    {
        inputConfig = new PlayerInputConfig();
        playerInput = GetComponent<PlayerInput>();
        
        // Get references to our actions
        movementAction = inputConfig.GamePlay.Movement;
        strengthAction = inputConfig.GamePlay.Strength;
        movementConfirmedAction = inputConfig.GamePlay.MovementConfirmed;

        playerInput.onControlsChanged += OnControlsChanged;
        OnControlsChanged(playerInput);
    }


    void Start()
    {
        // find player transform
    }

    void OnEnable()
    {
        inputConfig.Enable();
        inputConfig.GamePlay.Enable();
    }

    void OnDisable()
    {
        inputConfig.Disable();
        inputConfig.GamePlay.Disable();
    }

    private void OnControlsChanged(PlayerInput input)
    {
        isKeyboardMouseScheme = input.currentControlScheme == "KeyboardMouse";
    }

    protected override void Update()
    {
        base.Update();
        
        if (isKeyboardMouseScheme)
        {
            HandleKeyboardMouseInput();
        }
        else
        {
            HandleGamepadInput();
        }

        singlePressTimer -= Time.deltaTime;
    }

    private void HandleKeyboardMouseInput()
    {
        // if (!movementConfirmedAction.IsPressed())
        // {
        //     direction = Vector3.zero;
        //     arrowIndicator.HideArrow();
        //     return;
        // }

        Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
        RaycastHit hit;

        switch (inputVersion)
        {
            case 1:
                // Update strength based on scroll wheel
                float scrollDelta = Mouse.current.scroll.ReadValue().y;
                strength = Mathf.Clamp(strength + scrollDelta * strengthChangeSpeed * Time.deltaTime, minStrength, maxStrength);

                // if strength is too low, hide arrow
                if (strength < 0.01f)
                {
                    arrowIndicator.HideArrow();
                    return;
                }

                if (Physics.Raycast(ray, out hit, Mathf.Infinity, groundLayerMask))
                {
                    Vector3 hitPosition = hit.point;
                    direction = (hitPosition - bike.transform.position).normalized;
                    arrowIndicator.SetArrow(direction, strength);
                }
                break;
            case 2:
                strength = 0;

                if (Physics.Raycast(ray, out hit, Mathf.Infinity, groundLayerMask))
                {
                    Vector3 hitPosition = hit.point;
                    direction = (hitPosition - bike.transform.position).normalized;
                    arrowIndicator.SetArrow(direction, 1);
                }

                break;
            case 3:
                // only change direction if left mouse button is pressed
                if (Mouse.current.leftButton.isPressed)
                {
                    // use soap variable (UI)
                    strength = strengthVariable.Value;
                    // if strength is too low, hide arrow
                    if (strength < 0.01f)
                    {
                        arrowIndicator.HideArrow();
                        return;
                    }

                    // if mouse is over UI, break
                    // find the raycaster by name (it's ugly, but it works)
                    if (raycaster == null)
                    {
                        raycaster = GameObject.Find("Canvas_Stats").GetComponent<GraphicRaycaster>();
                    }
                    if (raycaster.KS_IsMouseOverUI())
                    {
                        arrowIndicator.SetArrow(direction, strength);
                        break;
                    }

                    if (Physics.Raycast(ray, out hit, Mathf.Infinity, groundLayerMask))
                    {
                        Vector3 hitPosition = hit.point;
                        direction = (hitPosition - bike.transform.position).normalized;
                        arrowIndicator.SetArrow(direction, strength);
                    }
                    break;
                }
                break;

            case 4:
                // get the direction from the mouse position, and strength also from the mouse position
                if (Physics.Raycast(ray, out hit, Mathf.Infinity, groundLayerMask))
                {
                    Vector3 hitPosition = hit.point;
                    direction = (hitPosition - MegaBike.Instance.playerBikeSeat.transform.position).normalized;

                    // convert mouse position to strength, using screen coordinates
                    Vector2 mousePosition = Mouse.current.position.ReadValue();
                    Vector2 playerScreenPosition = Camera.main.WorldToScreenPoint(MegaBike.Instance.playerBikeSeat.transform.position);
                    Vector2 screenDirection = mousePosition - playerScreenPosition;
                    strength = screenDirection.magnitude * mousePositionToStrengthMultiplier;
                    Debug.Log($"Mouse Position: {mousePosition}, Player Screen Position: {playerScreenPosition}, Screen Direction: {screenDirection}, Strength: {strength}");
                    strength = Mathf.Clamp(strength, minStrength, maxStrength);

                    strengthVariable.Value = strength;

                    // if strength is too low, hide arrow
                    if (strength < smallStrengthThreshold)
                    {
                        arrowIndicator.HideArrow();
                        return;
                    }

                    arrowIndicator.SetArrow(direction, strength);
                }
                break;
                
        }
        

        
        // else
        // {
        //     arrowIndicator.HideArrow();
        // }
    }

    private void HandleGamepadInput()
    {
        Vector2 movement = movementAction.ReadValue<Vector2>();
        
        if (movement.sqrMagnitude < 0.1f)
        {
            direction = Vector3.zero;
            arrowIndicator.HideArrow();
            return;
        }
        

        // show arrow direction
        direction = new Vector3(movement.x, 0, movement.y).normalized;
        direction *= -1;

        switch (inputVersion)
        {

            case 1:
                // Update strength based on right stick vertical
                float stickDelta = strengthAction.ReadValue<float>();
                strength = Mathf.Clamp(strength + stickDelta * strengthChangeSpeed * Time.deltaTime, minStrength, maxStrength);
                arrowIndicator.SetArrow(direction, strength);
                break;
            case 2:
                strength = 0;
                arrowIndicator.SetArrow(direction, 1);
                break;
        }
    }

    // Add method to reset strength if needed
    public void ResetStrength()
    {
        strength = minStrength;
    }


    void OnDestroy()
    {
        if (playerInput != null)
        {
            playerInput.onControlsChanged -= OnControlsChanged;
        }
    }


    // Unity events
    public override void OnMovementConfirmed(InputAction.CallbackContext context)
    {
        if (inputVersion != 2) return;

        if (singlePressTimer > 0)
        {
            return;
        }

        if (context.performed)
        {
            if (!forceApplied)
            {
                base.OnMovementConfirmed(context);
                if (agentCharacter != null)
                {
                    agentCharacter.PlayApplyForceAnimation(direction);
                }
                forceApplied = true;
            }
        }

        if (context.canceled)
        {
            if (forceApplied)
            {
                singlePressTimer = singlePressCD;
                forceApplied = false;
            }
        }
    }
}
