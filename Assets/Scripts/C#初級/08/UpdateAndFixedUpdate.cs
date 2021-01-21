using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateAndFixedUpdate : MonoBehaviour
{
    //調用Mono的函數可以用快捷鍵command/contrl+shift+M避免大小寫打錯
    //如果启用 MonoBehaviour，则每个固定帧速率的帧都将调用此函数
    void FixedUpdate()
        //called every physics step
        //FixedUpdate intervals are consistent
        //Used for regular updates such as:
        //Adjusting physics(Ridgidbody) objects
    {
        Debug.Log("FixedUpdate time :" + Time.deltaTime );
    }

    // Update is called once per frame
    void Update()
    //called every frame
    //used for regular updates such as：
    //Moving non-physics objects
    //Simple Timers
    //Receiving Input

    //Update interval times vary
    {
        Debug.Log("Update time :"+ Time.deltaTime);
    }
}
