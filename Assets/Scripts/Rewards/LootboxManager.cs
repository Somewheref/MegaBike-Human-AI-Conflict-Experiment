// cspell:disable


using UnityEngine;
using KayphoonStudio;
using KayphoonStudio.Components;
using System.Collections.Generic;

public class LootboxManager : KS_Singleton<LootboxManager>
{
    public KS_SimpleSpawner LootboxSpawner;

    public List<Lootbox> Lootboxes;

    public int maxLootboxes = 100;
    public bool replanishLootboxes = true;


    void Start()
    {
        SpawnLootbox();

        // KS_NotificationCenter.AddEventListener(NKeys.OnLootboxOpened, OnLootboxOpened);
        KS_NotificationCenter.AddEventListener(NKeys.OnLootboxDestroyed, OnLootboxDestroyed);
    }

    // void OnLootboxOpened(Notification notification)
    // {
    //     Lootbox openedLootbox = (Lootbox)notification.param;
    //     if (Lootboxes.Contains(openedLootbox))
    //         Lootboxes.Remove(openedLootbox);
        
    //     if (replanishLootboxes)
    //         SpawnLootbox();
    // }

    void OnLootboxDestroyed(Notification notification)
    {
        Lootbox destroyedLootbox = (Lootbox)notification.param;
        if (Lootboxes.Contains(destroyedLootbox))
            Lootboxes.Remove(destroyedLootbox);
        
        if (replanishLootboxes)
            KS_Timer.DelayedAction(Random.Range(0.1f, 1f), SpawnLootbox);
    }

    public void SpawnLootbox()
    {
        if (LootboxSpawner == null) return;

        if (Lootboxes == null)
            Lootboxes = new List<Lootbox>();

        if (Lootboxes.Count >= maxLootboxes)
            return;

        int i = 0;

        while (Lootboxes.Count < maxLootboxes && i < 100)
        {
            List<GameObject> spawnedObjects = LootboxSpawner.SpawnObjects();
            
            foreach (var spawnedObject in spawnedObjects)
            {
                var lootbox = spawnedObject.GetComponent<Lootbox>();
                if (lootbox != null)
                    Lootboxes.Add(lootbox);
            }
        }

        if (i >= 100)
        {
            KS_Logger.LogError("Failed to spawn lootbox for some reason");
        }
    }

    public void SetMaxLootboxes(float maxLootboxes)
    {
        this.maxLootboxes = (int)maxLootboxes;
    }

    // public void FixedUpdate()
    // {
    //     // check for any lootbox reference that is null and remove it
    //     Lootboxes.RemoveAll(lootbox => lootbox == null);
    //     if (replanishLootboxes)
    //     SpawnLootbox();
    // }
}
