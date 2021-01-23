using System.Collections;
using System;

using System.Collections.Generic;
using UnityEngine;

public class BadGuy :IComparable <BadGuy> //這裏繼承了mono排序會報錯
{
    public string name;
    public int power;

    public BadGuy(string newName,int newPower)
    {
        name = newName;
        power = newPower;
    }//分配這些數值的構造函數

   


    public int CompareTo(BadGuy other) //如果從中調用這個方法的對象大於被視作參數的對象，則函數返回正數
                                       //如果調用這個方法的對象小於被視作參數的對象，則函數返回負數
                                       //如果兩者相等，則函數返回0
                                       //定義一個對象是否大於另一對象，由程序員決定
    {
        //首先檢查傳入的這個對象是不是存在，如果不存在那調用方法的對象較大，函數應該返回正數
        //否則，方程返回兩個Badguy的power之差，因此如果從中調用方法的Badguy比較大，則返回正數
        //
        if (other==null)
        {
            return 1;
        }

        return power - other.power;//這個規則可以基於任意一個公式，我們只要完成接口的引用就可以
    }
}
