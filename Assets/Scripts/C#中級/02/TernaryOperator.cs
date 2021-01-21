using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TernaryOperator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int health = 10;
        string message;

        //message =health>0?"Player is Alive":"Player is Dead";
        message = health > 0 ? "Player is Alive" : health == 0 ? "Player is Barely Alive" : "Player is Dead";//":"後面是false後要執行的操作

        Debug.Log(message);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
