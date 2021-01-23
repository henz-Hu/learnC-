using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//在C#中,多态是通过派生类复写基类中的虚函数型的方法来实现
public class SomeScript : MonoBehaviour
{
    // protected 修飾符號介於private和public之間，最基础的三个访问修饰符：public 、private、protect.在搜索过程中又看到有一种和他们放在了一起，那就是internal.接下来就四个访问修饰符做一个简答的总结和介绍。

    //public：公有访问，不受任何限制。

    //   private：私有访问，只限于本类成员访问，子类、实例都不能访问。

    //   protected：保护访问，只限于本类和子类访问，实例不能访问。

    //   internal：内部访问，只限于本项目内访问，其他不能访问。

    //   public人缘好，跟谁都好，protect只和熟人好，private比较自闭．不过他们是三胞胎．class是他们的爹。

    //   例：

    //    比如说：一个人A为父类，他的儿子B，妻子C，私生子D（注：D不在他家里），如果我们给A的事情增加修饰符：

    //   public事件，地球人都知道，全公开

    //   protected事件，A，B，D知道（A和他的所有儿子知道，妻子C不知道）

    //   private事件，只有A知道（隐私？心事？）

    //   internal事件，A，B，C知道（A家里人都知道，私生子D不知道）

    //  注意事项：

    // 1,命名空间上不允许使用访问修饰符。命名空间没有访问限制。 

    // 2,一个成员或类型只能有一个访问修饰符，使用 protectedinternal 组合时除外

    // 3,assembly中的class默认访问修饰符为internal

    //4,类中的字段默认为private

    //5,类中的方法默认为private，包括构造函数
    void Start()
    {
        Employee E = new Employee();
        E.GetInfo();

        //DerivedClass a = new DerivedClass();
        DerivedClass.Main();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


//base 关键字用于从派生类中访问基类的成员：

//调用基类上已被其他方法重写的方法。

//指定创建派生类实例时应调用的基类构造函数。

//基类访问只能在构造函数、实例方法或实例属性访问器中进行。

//从静态方法中使用 base 关键字是错误的。

//所访问的基类是类声明中指定的基类。例如，如果指定 class ClassB : ClassA，则无论 ClassA 的基类如何，从 ClassB 上访问 ClassA 的成员。

//在本例中，基类 Person 和派生类 Employee 都有一个名为 Getinfo 的方法。通过使用 base 关键字，可以从派生类中调用基类的 Getinfo 方法。

public class Person 
{ 
    protected string ssn = "444-55-6666"; 
    protected string name = "John L. Malgraine"; 
    public virtual void GetInfo() 
    { 
    Debug.Log("Name: {0}"+"  "+ name);
    Debug.Log("SSN: {0}" +"  "+ ssn); 
    } 
}
class Employee : Person
{
    public string id = "ABC567EFG"; 
    public override void GetInfo()
    { // Calling the base class GetInfo method:
     base.GetInfo();//調用父類中的方法
     Debug.Log("Employee ID: {0}"+"  "+id); 
     } 
 }






//本示例显示如何指定在创建派生类实例时调用的基类构造函数。

public class BaseClass 
{ 
    int num; 
    public BaseClass() 
    { 
        Debug.Log("in BaseClass()"); 
    } 
    public BaseClass(int i) 
    { 
        num = i;
        Debug.Log("in BaseClass("+i+")"); 
    } 
    public int GetNum() 
    {   
        return num; 
    } 
}


public class DerivedClass : BaseClass 
{ // This constructor will call BaseClass.BaseClass() 
    public DerivedClass() : base() { } // This constructor will call BaseClass.BaseClass(int i) 
    public DerivedClass(int i) : base(i) { } 
    public static void Main() 
    { 
        DerivedClass md = new DerivedClass();
        DerivedClass md1 = new DerivedClass(1); 
    } 
} /* Output: in BaseClass() in BaseClass(int i) */