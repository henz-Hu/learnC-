using System.Collections;
using System.Collections.Generic;//這個“.”表示命名空間也是可以嵌套的
//namespace System{
//    namespace Collections
//    {
//        namespace Generic
//        {

//        }
//    }
//}
using UnityEngine;
//using SampleNamespace;//用來引用namespace的一種方法

public class SomeOtherClass12 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SampleNamespace.SomeClass12 myClass = new SampleNamespace.SomeClass12();//第二種方法但是寫起來繁瑣

        myClass.Start();                                                                        //還有一種方法一般不建議，除非要把當前的類也放入相同的命名空間：就把當前的類也包裹到同樣的命名空間中再去使用要使用的類  
        System.Random random0;
        UnityEngine.Random random;
        //這個時候就需要用點語法來說明清楚
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
