using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingDeltaTime : MonoBehaviour
{
    //delta 的意思是指兩個數值之間的差異

    public float speed = 8;
    public float countdown = 3.0f;

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0.0f)
            GetComponent<Light>().enabled = true;

        if (Input.GetKey(KeyCode.RightArrow))
            transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);

    }

        //time.deltatime 指兩次更新之間的時間或者固定更新函數調用之間的時間間隔
}
