using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeClass5 
{
    //getComponents<>()就是一種範型method
        //public T GenericMethod<T>(T param) where T  :class
        //where之後的是為了對——範型參數進行限制，“：”後面的是限制內容，通常有四類：
        //class referencetype的數據類型;struct valuetype的數據類型;new（）不含參數的公共構造函數;MonoBehavior ，類的名稱來表示T就代表那個類，或者通過多態表示T代表從中
        //衍生的任意類；還可以用接口(interface)名稱來表示T

        public T GenericMethod<T>(T param) where T:struct
        //public T GenericMethod<T>(T param) where T:new()
        //public T GenericMethod<T>(T param) where T:MonoBehavior 
        //public T GenericMethod<T>(T param) where T:IEnumerable
    {
        //....some other
        return param;
    }

    //public T GenericMethod<T,U,V>(T param)//範型參數一般在方法名後面，形叁前面，多個參數一般按照字幕順序往後些，一般從T開始，也可以隨便寫，一般很少人會寫超過三個  
    //{
    //    return param;
    //}
}
