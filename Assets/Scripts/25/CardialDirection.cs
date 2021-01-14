using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardialDirection : MonoBehaviour
{
    enum Direction {North,East,South,West};//默認枚舉中的每個元素都有一個從0開始往上數的對應整數值，North=》0，East=》1，。。。
    //我們也可以通過不同的聲明方式改變這種默認的附值方式如：
    //enum Direction {North=1,East,South,West};//這樣枚舉種的元素所對應的值就會是從1開始的整數。
    //再如：
   // enum Direction { North=10,East=11,South=15,West=27};
   //再如：我們可以更改枚舉元素為除int外的任意整數類型通過：
   //enum Direction : short { North, East, South, West };//
   //int a、long、short 等
   //一个short int型变量的最大允许值为32767，如果再加1，结果是多少呢？
//#include <stdio.h>
//void main() {
//       short int a,b;
//       a=32767;
//       b=a+1;
//       printf("a=%d,a+1=%d\n",a,b);
//       a=-32768;
//       b=a-1;
//printf("\na=%d,a-1=%d\n",a,b);
//}
//该程序发生的情况称为“溢出”，但运行时不报错。32767+1应该等于32768，但运行结果却是-32768。

    // Start is called before the first frame update
    void Start()
    {
        Direction myDirection;
        myDirection = Direction.North;
    }

    Direction ReverseDirection(Direction dir) 
    {
        if (dir == Direction.North)
            dir = Direction.South;
        else if (dir == Direction.South)
            dir = Direction.North;
        else if (dir == Direction.East)
            dir = Direction.West;
        else if (dir == Direction.West)
            dir = Direction.East;

        return dir;
    
    }
    // Update is called once per frame
    void Update()
    {
        
    }

}
