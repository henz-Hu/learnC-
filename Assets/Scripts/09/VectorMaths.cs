using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorMaths : MonoBehaviour
{
    Vector3 VectorA, VectorB;
    //unity的向量座標運用的是左手守則 拇指水平向右代表X軸，食指豎直向上代表Y軸，中指垂直向內代表z軸正方向
    // Start is called before the first frame update
    void Start()
    {
        Vector3.Cross(VectorA,VectorB);//兩個向量叉乘出新的向量；用來判斷運動眾增加扭矩？
        Vector3.Dot(VectorA,VectorB );//兩個向量點乘出一個直，如果值是0兩個向量就相互垂直，負值為鈍角
        //正值為銳角 cosA。


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
