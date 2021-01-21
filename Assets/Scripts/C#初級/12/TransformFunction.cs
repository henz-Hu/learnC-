using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformFunction : MonoBehaviour
{

    public float moveSpeed = 10f;
    public float turnSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
          //vector(0,0,1)=vector3.forward
          //GetKey只要按住就觸發，getkeydown按住只算觸發一次那就需要不斷的按顯然不合理
        if(Input.GetKey(KeyCode.UpArrow ))
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate (Vector3.up , -turnSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);

    }
}
