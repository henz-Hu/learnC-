using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatatypeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Vector3 currentPosition = transform.position;
        //currentPosition = new Vector3(0,2,0);//currentPosition是ValueType是用來保存數據值的，可以理解為原有對象的數據備份。更改並不會影像原有的對象


        Transform tran = transform;
        tran.position = new Vector3(0,2,0);//Transform 是一個引用類型，我們將對象的transform附值給tran，用的是附值預算，所以他們指向同一個存儲地址，因此更改其中一個另外一個
        //也會變
    
    
    }

   
}
