using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtScript : MonoBehaviour
{
    public Transform target;


    // Update is called once per frame
    void Update()
    {
        Vector3 relativePos = target.position - transform.position;
        transform.rotation = Quaternion.LookRotation(relativePos);//旋轉以面向對象，參數是Vector3返回於Vector3等效的四元數，對象的Z軸指向target
        //transform.rotation = Quaternion.LookRotation(relativePo,new Vector3(0,1,0));//第二個參數被用來告知函數哪個方向被認為是向上的。
    }
}
