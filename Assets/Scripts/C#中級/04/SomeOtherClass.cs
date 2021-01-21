using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //SomeClass myClass = new SomeClass();
        //myClass.Add(1,1);
        //myClass.Add("hello","world");
        ////與傳入參數完全匹配時
        ////不完全匹配時系統將選擇一個需要最少轉換量的版本
        ////沒有匹配的項就報錯 
        /// 
        int x = SomeClass.Add(1,2);
        string a = SomeClass.Add("hello","world");
        Debug.Log(x+"  "+a);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
