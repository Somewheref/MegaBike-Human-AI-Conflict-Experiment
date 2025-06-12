using UnityEngine;
using System.Collections.Generic;
[CreateAssetMenu(fileName = "CharacterCustomizationSO", menuName = "ScriptableObjects/CharacterCustomizationSO", order = 1)]
public class CharacterCustomizationSO : ScriptableObject
{
    public List<Sprite> EyeSprites;

    [System.Serializable]
    public class BodyCustomization
    {
        public Sprite bodySprite;
        public Sprite bodyFillSprite;
    }

    public List<BodyCustomization> BodyCustomizations;

    [Header("Default")]
    public Sprite defaultEyeSprite;
    public BodyCustomization defaultBodyCustomization;

    public Sprite GetRandomEyeSprite()
    {
        return EyeSprites[Random.Range(0, EyeSprites.Count)];
    }

    public BodyCustomization GetRandomBodyCustomization()
    {
        return BodyCustomizations[Random.Range(0, BodyCustomizations.Count)];
    }

    public Sprite GetDefaultEyeSprite()
    {
        return defaultEyeSprite;
    }

    public BodyCustomization GetDefaultBodyCustomization()  
    {
        return defaultBodyCustomization;
    }
}
