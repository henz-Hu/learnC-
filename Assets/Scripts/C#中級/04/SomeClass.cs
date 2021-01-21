using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SomeClass //如果改成靜態類所有方法都要改成靜態的
{
   public static int Add(int num1,int num2) //Add(int num1,int num2) 這是方法的signature，有方法名和參數列表組成。 
    {
        return num1 + num2;
   }
    public static string Add(string str1,string str2) 
    {
        return str1 + str2;
    }
}
