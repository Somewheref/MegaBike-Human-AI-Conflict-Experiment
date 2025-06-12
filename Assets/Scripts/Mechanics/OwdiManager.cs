using UnityEngine;
using KayphoonStudio;
using KayphoonStudio.Components;
using System.Collections.Generic;

public class OwdiManager : MonoBehaviour
{
    public KS_SimpleSpawner OwdiSpawner;

    public List<Owdi> Owdis;

    public int maxOwdis = 100;
    public bool replanishOwdis = true;


    void Start()
    {
        KS_NotificationCenter.AddEventListener(NKeys.OnOwdiSacrificeStart, OnOwdiCrashedIntoBike);
        // KS_NotificationCenter.AddEventListener(NKeys.OnLootboxDestroyed, OnLootboxDestroyed);
    }


    void OnOwdiCrashedIntoBike(Notification notification)
    {
        
    }

    public void SpawnOwdis()
    {
        if (OwdiSpawner == null) return;

        if (Owdis == null)
            Owdis = new List<Owdi>();

        if (Owdis.Count >= maxOwdis)
            return;

        int i = 0;

        while (Owdis.Count < maxOwdis && i < 100)
        {
            List<GameObject> spawnedObjects = OwdiSpawner.SpawnObjects();
            
            foreach (var spawnedObject in spawnedObjects)
            {
                var owdi = spawnedObject.GetComponent<Owdi>();
                if (owdi != null)
                    Owdis.Add(owdi);
            }
        }

        if (i >= 100)
        {
            KS_Logger.LogError("Failed to spawn owdi for some reason");
        }
    }

    public void SetMaxOwdis(float maxOwdis)
    {
        this.maxOwdis = (int)maxOwdis;
        SpawnOwdis();
    }

    // public void FixedUpdate()
    // {
    //     // check for any lootbox reference that is null and remove it
    //     Lootboxes.RemoveAll(lootbox => lootbox == null);
    //     if (replanishLootboxes)
    //     SpawnLootbox();
    // }
}
