using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ClickSetPosition : MonoBehaviour
{
    public PropertiesAndCoroutines coroutineScript;
   
   

    private void OnMouseDown()
    {

        Debug.Log("mouseDown");

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);//体会：不理解或是第一次见的类、结构一定要亲自查API文档，并在脚本中试一试；看了文档还是不理解就百度、问人）

        //文档中说：产生的射线是在世界空间中，从相机的近裁剪面开始并穿过屏幕position(x, y)像素坐标（position.z被忽略）。
// 那么为什么要把鼠标位置转化为屏幕位置呢？

//因为单位不一样；

//屏幕空间点用像素定义，屏幕的左下为(0, 0); 右上是（PixelWidth，pixelHeight）.Z的位置是以世界单位衡量的到相机的距离。是像素坐标。

//而摄像机的Vector3则是世界坐标，所以需要把屏幕上的点转化为世界坐标。

//ScreenPointToRay（）函数可以把屏幕像素坐标变成一条射线。



        RaycastHit hit;//這個時候還是空的



//        下面说说Physics.Raycast（）

//API文档中只给出这几个方法：

//public static bool Raycast(Ray ray, RaycastHit hitInfo, float distance, int layerMask);

//public static bool Raycast(Ray ray, float distance, int layerMask);

//public static bool Raycast(Vector3 origin, Vector3 direction, float distance, int layerMask);

//public static bool Raycast(Vector3 origin, Vector3 direction, RaycastHit , float distance ，int layerMask);


        Physics.Raycast(ray,out hit);

        if (hit.collider.gameObject==gameObject) 
        {
            Debug.Log("hit");
            Vector3 newTarget = hit.point + new Vector3(0,0.5f,0);
            coroutineScript.Target = newTarget;
        }
    }

   

   

}
