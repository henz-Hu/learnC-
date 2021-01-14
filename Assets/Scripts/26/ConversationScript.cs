using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationScript : MonoBehaviour
{
    //switch是用但一變量和不同常量進行比較的語句，通常用來做決策，依據是enums
    //這個例子基於智力水平說出對話結果
    public enum IntelligenceLevel { smartest=5, Smart=4, lessSmart=3, common=2, idiotest=1, error=0 };
    IntelligenceLevel intelligence = IntelligenceLevel.smartest;

    void Greet() 
    {
        switch (intelligence)
        {
            case IntelligenceLevel.smartest:
                print("Why hello there good sir! Let me teach you about Trigonometry!");
                break;
            case IntelligenceLevel.Smart:
                print("hello and good day! ");
                break;//如果前面一種條件不寫break，前兩個條件相當於or
            case IntelligenceLevel.lessSmart:
                print("whadya want! ");
                break;
            case IntelligenceLevel.common:
                print("Grog SMASH! ");

                break;
            case IntelligenceLevel.idiotest:
                print("Ulg,glib,Pblblblb ");

                break;               
            default:
                print("error ");
                break;
        }
    }
     void Start()
    {
        Greet();
    }
}
