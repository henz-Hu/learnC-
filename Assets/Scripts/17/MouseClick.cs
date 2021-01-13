using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void OnMouseDown()
    {
        Debug.Log("Click on the Cube!");
        rb.AddForce(-transform.forward*500f);//產生物體的localtransform的-z軸的力
        rb.useGravity = true;
    }
}
