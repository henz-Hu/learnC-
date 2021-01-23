using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//event是一種特殊的delegat，對delegate進行了規範,
public class EventManager : MonoBehaviour
{
    public delegate void Click();
    public static Click myClick;//對比，這是聲明委託,只有十static的變量才能不new 就直接使用.3使用event而非委託的一個原因是event具有內在的安全性，他不能被其他類更改，而委託變量是可以被其他類
    //調用或者覆蓋的，如果想要創建包含多個類的動態方法系統，使用事件變量而不是委託變量
    public static event Click OnClicked;//我們把ClickAction();存進了監聽事件裡，這個事件叫OnClicked
    //然後這個類只負責當發生相應情況是，調用事件
    //這個腳本並不負責事件的訂閱，此時這個事件中和沒有任何訂閱。。所以是空

    private void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 2 - 50, 5, 100, 30), "Click"))
        {

            //當玩家點擊按鈕時，我們會像使用函數一樣使用事件變量OnClicked();這實際上調用了我們的事件，和委託一樣
            //調用前要確保事件有被寫入 “+=”  
            if (OnClicked != null)
            {
                OnClicked();

            }

            if (myClick != null)
            {
                myClick();

            }
        }     
    }
}
