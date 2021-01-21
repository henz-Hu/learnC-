using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherClass5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SomeClass5 myClass = new SomeClass5();
        myClass.GenericMethod<float>(5.0f);
        myClass.GenericMethod<int>(1);
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
