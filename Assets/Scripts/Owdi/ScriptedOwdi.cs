using System.Collections;
using UnityEngine;

public class ScriptedOwdi : MonoBehaviour
{
    public Transform BikeTransform;
    public GameObject OwdiPrefab;

    public float StartDelay = 60f;

    public float spawnRadius = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    IEnumerator Start()
    {
        yield return new WaitForSeconds(StartDelay);
        SpawnOwdi();
    }


    void SpawnOwdi()
    {
        Vector2 spawnDirection = Random.insideUnitCircle.normalized;
        Vector3 spawnPosition = BikeTransform.position +  (Vector3)spawnDirection * spawnRadius;
        spawnPosition.y = transform.position.y; // Keep the spawn position at the same height as the bike

        GameObject owdi = Instantiate(OwdiPrefab, spawnPosition, Quaternion.identity);
        gameObject.SetActive(false);
    }


    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(BikeTransform.position, spawnRadius);
        Gizmos.DrawLine(BikeTransform.position, transform.position);
    }
}
