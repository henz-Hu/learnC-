using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableComponent : MonoBehaviour
{
    private Light myLight;
    // Start is called before the first frame update
    void Start()
    {
        myLight = GetComponent<Light>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input .GetKeyDown (KeyCode.Space )) 
        {
            myLight.enabled = !myLight.enabled; //和之前的狀態相反。。。要記住這種寫法！！！
        }
    }
}
