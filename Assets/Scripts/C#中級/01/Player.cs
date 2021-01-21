using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private int experience;//字段 field 用來封裝屬性，規定調用的方式

    public int Experience
    {//括號內是屬性的訪問器
        get 
        {//some other code
            return experience;
        }
        set 
        {
            //some other code
            experience = value;
        }
    }
//還可以來創建協程？？
    public int Level
    {
        get 
        {
            return experience / 1000;
        }
        set 
        {
//給定level之後就算出了experience並儲這個字段。
            experience = value * 1000;
        }
    }
//所有和字段相關的外部改變都能改變封裝在該字段內的所有屬性
    public int MyProperty { get; set; }//可以通過prop來創建屬性，get是只讀，set只寫
}