using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBasic : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input .GetKey (KeyCode.Space ))
        {
            Destroy(gameObject,3f);//延時三秒在銷毀，gameObject
        }
    }
}
