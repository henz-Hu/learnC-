using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    private void OnEnable()//在場景內創建或啟用這個腳本關聯的的對象時會被調用
    {
        EventManager.OnClicked += TelePort;//將TelePort訂閱到事件
        //EventManager.myClick += TelePort;
    }

    private void OnDisable()
    {
        EventManager.OnClicked -= TelePort;
       // EventManager.myClick -= TelePort;

    }
    //有加有減否則可能會內存洩漏
    void TelePort()
    {
        Vector3 pos = transform.position;
        pos.y = Random.Range(.3f,1.0f);
        transform.position = pos;

    }//這裏要和delegate保持一致
}
