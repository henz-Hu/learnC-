using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccessModifiers : MonoBehaviour
{
    // Start is called before the first frame update、
    public int alpha = 5;

    private int beta = 0;
    private int gamma = 5;

    private AnotherClass myOtherClass;

    void Start()
    {
        alpha = 29;
        myOtherClass = new AnotherClass();//初始化一個其他腳本寫的類
        myOtherClass.FruitMachine(alpha,myOtherClass .apples);//可以使用其他類的公共變量和自己類中的變量

    }


    void Example(int pens,int crayons)
    {
        int answer;
        answer = pens * crayons * alpha;
        Debug.Log(answer); 
    }



    // Update is called once per frame
    void Update()
    {
        Debug.Log("Alpha is set to:"+alpha ); 
    }
}
