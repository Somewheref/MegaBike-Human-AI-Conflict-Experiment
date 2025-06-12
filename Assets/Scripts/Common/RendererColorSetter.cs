using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Sirenix.OdinInspector;
using KayphoonStudio;
using System.Collections;

public class RendererColorSetter : MonoBehaviour
{
    public enum RendererType
    {
        None,
        MeshRenderer,
        LineRenderer,
        Image,
        TextMeshPro,
        SpriteRenderer
    }

    [Required]
    public IAgentColor agentColor;

    [BoxGroup("Renderer Settings")]
    [OnValueChanged("OnRendererTypeChanged")]
    public RendererType rendererType;

    [BoxGroup("Renderer Settings")]
    [ShowIf("rendererType", RendererType.MeshRenderer)]
    public MeshRenderer meshRenderer;

    [BoxGroup("Renderer Settings")]
    [ShowIf("rendererType", RendererType.LineRenderer)]
    public LineRenderer lineRenderer;

    [BoxGroup("Renderer Settings")]
    [ShowIf("rendererType", RendererType.Image)]
    public Image image;

    [BoxGroup("Renderer Settings")]
    [ShowIf("rendererType", RendererType.TextMeshPro)]
    public TextMeshProUGUI tmpText;

    [BoxGroup("Renderer Settings")]
    [ShowIf("rendererType", RendererType.SpriteRenderer)]
    public SpriteRenderer spriteRenderer;

    [BoxGroup("Color Settings")]
    [Range(0, 1)]
    [OnValueChanged("UpdatePreviewColor")]
    public float saturation = 1f;

    [BoxGroup("Color Settings")]
    [ReadOnly]
    [ShowInInspector]
    private Color previewColor;

    private Color baseColor;

    void Reset()
    {
        agentColor = GetComponentInParent<IAgentColor>();

        if (agentColor == null)
        {
            KS_Logger.LogError("No IAgentColor component found in parent");
        }

        // auto-fetch renderer type
        if (TryGetComponent(out MeshRenderer meshRenderer))
        {
            rendererType = RendererType.MeshRenderer;
            this.meshRenderer = meshRenderer;
        }
        else if (TryGetComponent(out LineRenderer lineRenderer))
        {
            rendererType = RendererType.LineRenderer;
            this.lineRenderer = lineRenderer;
        }
        else if (TryGetComponent(out Image image))
        {
            rendererType = RendererType.Image;
            this.image = image;
        }
        else if (TryGetComponent(out TextMeshProUGUI tmpText))
        {
            rendererType = RendererType.TextMeshPro;
            this.tmpText = tmpText;
        }
        else if (TryGetComponent(out SpriteRenderer spriteRenderer))
        {
            rendererType = RendererType.SpriteRenderer;
            this.spriteRenderer = spriteRenderer;
        }
    }

    IEnumerator Start()
    {
        yield return new WaitForEndOfFrame();
        GetAgentColor();
        UpdatePreviewColor();
        ApplyColor();
    }

    private void GetAgentColor()
    {
        if (agentColor == null)
        {
            agentColor = GetComponentInParent<IAgentColor>();
        }

        if (agentColor != null)
        {
            baseColor = AgentColorData.GetColor(agentColor.GetAgentColor());
            UpdatePreviewColor();
        }
    }

    private void UpdatePreviewColor()
    {
        // Lerp from white to base color based on saturation
        previewColor = Color.Lerp(Color.white, baseColor, saturation);
    }

    [Button("Apply Color")]
    private void ApplyColor()
    {
        if (baseColor == default(Color))
        {
            GetAgentColor();
        }

        switch (rendererType)
        {
            case RendererType.MeshRenderer:
                if (meshRenderer != null && meshRenderer.material != null)
                {
                    meshRenderer.material.color = previewColor;
                }
                break;

            case RendererType.LineRenderer:
                if (lineRenderer != null)
                {
                    // Preserve original alpha values
                    Color startColor = lineRenderer.startColor;
                    Color endColor = lineRenderer.endColor;
                    
                    startColor = Color.Lerp(Color.white, baseColor, saturation);
                    endColor = Color.Lerp(Color.white, baseColor, saturation);
                    
                    // Restore original alpha
                    startColor.a = lineRenderer.startColor.a;
                    endColor.a = lineRenderer.endColor.a;
                    
                    lineRenderer.startColor = startColor;
                    lineRenderer.endColor = endColor;
                }
                break;

            case RendererType.Image:
                if (image != null)
                {
                    image.color = previewColor;
                }
                break;

            case RendererType.TextMeshPro:
                if (tmpText != null)
                {
                    tmpText.color = previewColor;
                }
                break;

            case RendererType.SpriteRenderer:
                if (spriteRenderer != null)
                {
                    spriteRenderer.color = previewColor;
                }
                break;
        }
    }

    #if UNITY_EDITOR
    private void OnRendererTypeChanged()
    {
        // Clear all renderer references when type changes
        meshRenderer = null;
        lineRenderer = null;
        image = null;
        tmpText = null;
        spriteRenderer = null;

        // Auto-fetch component if it exists on the same GameObject
        switch (rendererType)
        {
            case RendererType.MeshRenderer:
                meshRenderer = GetComponent<MeshRenderer>();
                break;
            case RendererType.LineRenderer:
                lineRenderer = GetComponent<LineRenderer>();
                break;
            case RendererType.Image:
                image = GetComponent<Image>();
                break;
            case RendererType.TextMeshPro:
                tmpText = GetComponent<TextMeshProUGUI>();
                break;
            case RendererType.SpriteRenderer:
                spriteRenderer = GetComponent<SpriteRenderer>();
                break;
        }
    }
    #endif
}
