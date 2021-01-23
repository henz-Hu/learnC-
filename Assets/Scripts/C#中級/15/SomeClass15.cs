using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeClass15 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.identity;//實際會將其歐拉角旋轉設置為(0，0，0)或者說無旋轉，四元數是處理旋轉的最好方法,千萬不要單獨修改其中一元數值
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
