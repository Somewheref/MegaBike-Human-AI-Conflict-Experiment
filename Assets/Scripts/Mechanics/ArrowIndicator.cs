using UnityEngine;

public class ArrowIndicator : MonoBehaviour
{
    public Transform start;
    public LineRenderer lineRenderer;
    public LineRenderer arrowHeadLR;
    public float arrowHeadLength = 1;
    public float arrowBodyLength = 10;
    public float arrowYOffset = 0.5f;

    private float length;
    private Vector3 dir;
    public bool isActive = false;
    private Vector3 currentDir;
    private float currentLength;
    public float smoothSpeed = 10f;

    [Header("2d offsets")]
    public float startingOffset = 0;
    public float endingOffset = 0;

    void LateUpdate()
    {
        if (isActive)
        {
            currentDir = Vector3.Lerp(currentDir, dir, Time.deltaTime * smoothSpeed);
            currentLength = Mathf.Lerp(currentLength, length, Time.deltaTime * smoothSpeed);
            
            lineRenderer.SetPosition(0, start.position + Vector3.up * arrowYOffset + startingOffset * currentDir);
            lineRenderer.SetPosition(1, start.position + currentDir * currentLength + Vector3.up * arrowYOffset + endingOffset * currentDir);
            arrowHeadLR.SetPosition(0, start.position + currentDir * currentLength + Vector3.up * arrowYOffset + endingOffset * currentDir);
            arrowHeadLR.SetPosition(1, start.position + currentDir * currentLength + currentDir * arrowHeadLength + Vector3.up * arrowYOffset + endingOffset * currentDir);
        }

        if (!isActive)
        {
            lineRenderer.enabled = false;
            arrowHeadLR.enabled = false;
        }
        else
        {
            lineRenderer.enabled = true;
            arrowHeadLR.enabled = true;
        }
    }
    
    public void SetArrow(Vector3 dir, float length)
    {
        dir.y = 0;
        dir.Normalize();
        this.dir = dir;
        this.length = length * arrowBodyLength;
        isActive = true;
    }

    public void HideArrow()
    {
        isActive = false;
    }
}
