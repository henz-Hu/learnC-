using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode ]//在編輯模式下執行，謹慎使用，這些操作是不可逆的，顏色更改或者物體刪除將是永久的，即使禁用腳本之後，
//也需要通過手動調整材質顏色才能更改過來

public class ColorScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().sharedMaterial.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
