using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeRepeating : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject",2,1); //兩秒之後調用SpawnObject函數，並且間隔一秒被重複調用 

        //CancelInvoke();//停止所有invoke，傳入參數就會指停止想要停止的函數調用
    }
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.Space)) 
        {
            CancelInvoke("SpawnObject");
        }
    }

    void SpawnObject()
    {
        float x = Random.Range(-2.0f,2.0f);
        float z = Random.Range(-2.0f,2.0f);
        Instantiate(target ,new Vector3(x,2,z),Quaternion .identity);
    }
}
