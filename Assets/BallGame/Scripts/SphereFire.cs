using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereFire : MonoBehaviour
{
    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void ThrowBall(float x, float y, float z)
    {
        rb.AddForce(x, y, z);
    }
}
