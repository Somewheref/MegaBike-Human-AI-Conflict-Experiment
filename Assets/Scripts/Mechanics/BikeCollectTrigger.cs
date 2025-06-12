using UnityEngine;

public class BikeCollectTrigger : MonoBehaviour
{
    public MegaBike megaBike;

    void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "Lootbox":
                megaBike.OpenedLootbox(other.GetComponentInParent<Lootbox>());
                break;
        }
    }
}
