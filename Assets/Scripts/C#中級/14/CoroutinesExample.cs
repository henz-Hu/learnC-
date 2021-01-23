using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//協程可以看成是按照時間間隔執行的函數，這類函數於特殊的yield語句搭配使用，yield語句從函數中返回代碼執行，然後當函數繼續時
//將從上次停止的地方開始執行
public class CoroutinesExample : MonoBehaviour
{
    public float smoothing = 1f;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MyCoroutine(target));
        //StartCoroutine("MyCoroutine");//?怎麼傳參數
        //StopCoroutine("MyCoroutine");//可以提前終止
    }

 IEnumerator MyCoroutine(Transform target)
    {
        while (Vector3.Distance (transform.position ,target.position)>0.05f) 
        {
            transform.position = Vector3.Lerp(transform.position,target.position,smoothing*Time.deltaTime );
            yield return null;//返回空，繼續判斷是否進入循環
        }
        //循環結束
        print("Reached the target.");
        yield return new WaitForSeconds(3f);//返回一個WaitForSeconds的類，並傳入3作為參數執行
        print("MyCoroutine is now finished");

    }
}
