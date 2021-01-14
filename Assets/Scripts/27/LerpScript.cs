using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpScript : MonoBehaviour
{
    public Light a;
    public Transform target;
    private Vector3 currentVelocity = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        float result = Mathf.Lerp(3f,5f,0.5f); //在制作游戏时，有时可以在两个值之间进行线性插值。这是通过 Lerp 函数来完成的。
        //线性插值会在两个给定值之间找到某个百分比的值。例如，我们可以在数字 3 和 5 之间按 50% 进行线性插值以得到数字 4。
        //这是因为 4 是 3 和 5 之间距离的 50%。
        //Lerp 函数的其他示例包括 Color.Lerp 和 Vector3.Lerp。这些函数的工作方式与 Mathf.Lerp 完全相同，
        //但是“from”和“to”值分别为 Color 和 Vector3 类型。
        //在每个示例中，第三个参数仍然是一个 float 参数，表示要插值的大小。
        //这些函数的结果是找到一种颜色（两种给定颜色的某种混合）以及一个矢量（占两个给定矢量之间的百分比）。

        Vector3 from = new Vector3(1f, 2f, 3f);
        Vector3 to = new Vector3(5f, 6f, 7f);

        // 此处 result = (4, 5, 6)
        Vector3 resultV = Vector3.Lerp(from, to, 0.75f);

        //使用 Color.Lerp 时适用同样的原理。在 Color 结构中，颜色由代表红色、蓝色、绿色和 Alpha 的 4 个 float 参数表示。
        //使用 Lerp 时，与 Mathf.Lerp 和 Vector3.Lerp 一样，这些 float 数值将进行插值。
    }

    // Update is called once per frame
    void Update()
    {
        //在某些情况下，可使用 Lerp 函数使值随时间平滑。请考虑以下代码段：
        a.intensity = Mathf.Lerp(a.intensity,8f,0.5f);
        //如果光的强度从 0 开始，则在第一次更新后，其值将设置为 4。下一帧会将其设置为 6，然后设置为 7，再然后设置为 7.5，依此类推。因此，
        //经过几帧后，光强度将趋向于 8，但随着接近目标，其变化速率将减慢。
        //请注意，这是在若干个帧的过程中发生的。如果我们不希望与帧率有关，则可以使用以下代码：
        a.intensity = Mathf.Lerp(a.intensity, 8f, 0.5f*Time.deltaTime);

        //这意味着强度变化将按每秒而不是每帧发生。
        //请注意，在对值进行平滑时，通常情况下最好使用 SmoothDamp 函数。
        //仅当您确定想要的效果时，才应使用 Lerp 进行平滑。

        //SmoothDamp:

        transform.position = Vector3.SmoothDamp(transform.position, target.position, ref currentVelocity, 1);//ref 表示每次調用函數都會被修改成當前速度

        //transform.position = Vector3.SmoothDamp(transform.position, target.position, ref velocity, smoothTime);


    }
}
