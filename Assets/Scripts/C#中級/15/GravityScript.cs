using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityScript : MonoBehaviour
{//實現軌道效應
    public Transform target;

   
    void Update()
    {
        Vector3 relativePos = (target.position + new Vector3(0, .5f, 0)) - transform.position;//將球的高度考慮進去，0.5h
        Quaternion rotation = Quaternion.LookRotation(relativePos);

        Quaternion current = transform.localRotation;//inspector中的rotation存儲的四元數信息

        transform.localRotation = Quaternion.Slerp(current,rotation,Time.deltaTime);//類似lerp但是會呈現sin函數類似的變加速的插值，用來模擬圓周向心運動
        transform.Translate(0,0,3*Time.deltaTime);//圓周速度
    }
}
