using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public Slingshot slingshot;
    private float direction;
    private Vector3 pos;
    public float maxForce = 15;
    public float force;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    public Vector3 Pos()
    {
        return rb.position;
    }

    void Update()
    {
        if (rb.velocity == new Vector3(0, 0, 0))
        {
            pos = rb.transform.position;
        }
        if (rb.transform.position.y < 0)
        {
            rb.transform.position = pos;
            rb.velocity = new Vector3(0, 0, 0);
        }
        direction = slingshot.GetDirection();
        force = maxForce * slingshot.GetDistance();
    }
    public void Push()
    {
        if(rb.velocity == new Vector3(0, 0, 0))
        {
        transform.rotation = Quaternion.Euler(0, transform.eulerAngles.y + direction, 0);
        rb.AddForce(transform.forward * force, ForceMode.Impulse);
        }
    }
}
