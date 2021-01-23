using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//通過委託可以通過代碼逕行複雜的操作，它像是存放函數的容器。就像變量是存放數值的容器，區別是變量
//包含data，delegates包含函數(functions)
//這可以很好的控制在遊戲運行中調用哪些函數
public class DelegatesScript : MonoBehaviour
{
    delegate void MyDelegate(int num);//void MyDelegate(int num)這部分是delegate的簽名
    MyDelegate myDelegate;

    void Start()
    {
        myDelegate = PrintNum;
        myDelegate(50);

        myDelegate = DoubleNum;
        myDelegate(50);
    }

    void PrintNum(int num)
    {
        print("Print Num:"+num);
    }

    void DoubleNum(int num)
    {
        print("DoubleNum Num:" + num*2);
    }
}
