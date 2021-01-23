using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//namespace是用來裝類的容器
namespace SampleNamespace
{


    public class SomeClass12 
    //相同的類名稱可以在不同的命名空間下並存，但是因為類名和腳本的名字相同，所以相同的類的腳本
    //不能放在同一個文件夾下。
    //這裏繼承mono 會報錯 不能用new 來實例化調用
    {
        // Start is called before the first frame update
        public void Start()
        {
            Debug.Log("binggo");
                
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}