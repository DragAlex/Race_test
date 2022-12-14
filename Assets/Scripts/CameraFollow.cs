using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float distance = 5.0f;
    public float height = 10.0f;
    public float damping = 5.0f;

    void Update()
    {
        Vector3 wantedPosition;
        wantedPosition = target.TransformPoint(0, height, -distance);
        transform.position = Vector3.Lerp(transform.position, wantedPosition, Time.deltaTime * damping);
        transform.LookAt(target, target.up);
    }
}
