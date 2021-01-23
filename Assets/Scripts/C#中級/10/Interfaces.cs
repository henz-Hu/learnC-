using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//接口的用處是跨多個不相關的類，實現通用方法
 interface IKillable //接口默認都是public的
                     //以上代码定义了接口 IMyInterface。通常接口命令以 I 字母开头，这个接口只有一个方法Kill()，没有参数和返回值，当然我们可以按照需求设置参数和返回值。
                     //值得注意的是，该方法并没有具体的实现。
{
    void Kill();
}



interface IDamageable<T>
{
    void Damage(T damageTaken);
}
//interface IParentInterface
//{
//    void ParentInterfaceMethod();
//}

//interface IMyInterface : IParentInterface
//{
//    void MethodToImplement();
//}

//class InterfaceImplementer : IMyInterface
//{
//    static void Main()
//    {
//        InterfaceImplementer iImp = new InterfaceImplementer();
//        iImp.MethodToImplement();
//        iImp.ParentInterfaceMethod();
//    }

//    public void MethodToImplement()
//    {
//        Console.WriteLine("MethodToImplement() called.");
//    }

//    public void ParentInterfaceMethod()
//    {
//        Console.WriteLine("ParentInterfaceMethod() called.");
//    }
//}