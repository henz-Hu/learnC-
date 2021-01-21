using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericClassExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GenericClass<int> myClass = new GenericClass<int>();
        myClass.UpdateItem(5); //常用於構建列表和dictionary；
        //myClass.UpdateItem(5.0f);這就是錯的
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
