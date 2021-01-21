using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UltilitiesExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int x = Utilities1.Add(1,1);//靜態類不是用來實例化的而是用來提供方法的？類似Input.getkey。。。之類的
       // Utilities1 a = new Utilities1();這是錯的
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
