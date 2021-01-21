using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeScript7 : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)//需要掛載有collider的gameobject上並且 collider需要勾選is trigger
    //不管是Collider，box Collider，Sphere Collider。。。。都適用
    //因為他符合 ：box、sphere、等子類Collider “IS A” Collider(父類）。
    //但反過來卻不成立
    {
        ParentClass myClass = new ChildClass();

        myClass.ParentMethod();
        //這個時候不能用子類的方法，需要轉型
        ChildClass myChild = (ChildClass)myClass;
        myChild.ChildMethod();
        
    }
}

public class ParentClass
{
   //public void ParentMethod() { }
    public void Test() { }
    public virtual void ParentMethod() 
   {
        Debug.Log("I am Base");
   }//可在派生類中被override,否則報錯


}
public class ChildClass : ParentClass
{

    public override void ParentMethod()
    {
        base.ParentMethod();
        Debug.Log("I am child");
    }//可

    public  void ChildMethod()
    {
        
        Debug.Log("I am child++++++");
    }
}
