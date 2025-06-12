using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public enum AgentColor
{
    Unassigned,
    Red,
    Green,
    Blue,
    Yellow,
    Purple,
    BlueGreen,
    Brown,
    Grey
}

public static class AgentColorData
{
    [Header("Colors")]
    public static Color Red = new Color(1, 0, 0);
    public static Color Green = new Color(0, 1, 0);
    public static Color Blue = new Color(0, 0, 1);
    public static Color Yellow = new Color(1, 1, 0);
    public static Color Purple = new Color(1, 0, 1);
    public static Color BlueGreen = new Color(0, 1, 1);
    public static Color White = new Color(1, 1, 1);
    public static Color Brown = new Color(0.545f, 0.271f, 0.075f);
    public static Color Grey = new Color(0.5f, 0.5f, 0.5f);

    public static Color GetColor(AgentColor color)
    {
        return color switch
        {
            AgentColor.Red => Red,
            AgentColor.Green => Green,
            AgentColor.Blue => Blue,
            AgentColor.Yellow => Yellow,
            AgentColor.Purple => Purple,
            AgentColor.BlueGreen => BlueGreen,
            AgentColor.Brown => Brown,
            AgentColor.Grey => Grey,
            _ => White,
        };
    }

    public static AgentColor GetRandomColor()
    {
        int maxColor = System.Enum.GetValues(typeof(AgentColor)).Length;
        return (AgentColor)Random.Range(1, maxColor);
    }

    public static AgentColor GetRandomColor(List<AgentColor> excludeColors)
    {
        // get all colors except the excluded ones and first one
        List<AgentColor> colors = System.Enum.GetValues(typeof(AgentColor)).Cast<AgentColor>().ToList();
        colors.RemoveAll(color => excludeColors.Contains(color));
        colors.RemoveAt(0);
        return colors[Random.Range(0, colors.Count)];
    }
}

