using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    public Slingshot slingshot;
    public Player player;
    private LineRenderer lineRenderer;
    private float direction;
    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.enabled = false;
    }

    public void Navigate()
    {
        lineRenderer.enabled = true;
        direction = slingshot.GetDirection();
        transform.rotation = Quaternion.Euler(0, direction + player.transform.eulerAngles.y, 0);
    }
    public void Hide()
    {
        lineRenderer.enabled = false;
    }
}
