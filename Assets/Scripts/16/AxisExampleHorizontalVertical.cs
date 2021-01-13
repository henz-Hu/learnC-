using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//手柄控制？
/*input.GetAxis 用法(GetAxis("Mouse X"),GetAxis("Mouse Y"),GetAxis("Mouse ScrollWheel"),GetAxis("Vertical "),GetAxis("Horizontal "),
GetAxis 是个方法，需要传参数，参数为string类型，参数如下：
            一：触屏类
                   1.Mouse X                       鼠标沿着屏幕X移动时触发
                   2.Mouse Y                       鼠标沿着屏幕Y移动时触发
                   3.Mouse ScrollWheel      当鼠标滚动轮滚动时触发
            二：键盘操作类
                   1.Vertical 对应键盘上面的上下箭头，当按下上或下箭头时触发
                   2.Horizontal 对应键盘上面的左右箭头，当按下左或右箭头时触发joystick手柄

    這是用來做偏移初始位置的操作，按下偏移不按就回來，也可以用來模擬加速度的位移               

    */

public class AxisExampleHorizontalVertical : MonoBehaviour
{

    public Text horizontalValueDisplayText;
    public Text verticalValueDisplayText;
    public float hRange;
    public float vRange;

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float xPos = h * hRange;
        float vPos = v * vRange;

        transform.position = new Vector3(xPos,0,vPos);
        horizontalValueDisplayText.text = h.ToString("F2");
        verticalValueDisplayText.text = v.ToString("F2");//小數點後兩位，在備忘錄裡有詳細記載
          
    }
}
