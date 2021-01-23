using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MulticastScript : MonoBehaviour
{
    delegate void MultiDelegate();
    MultiDelegate myMultiDelegate;

    void Start()
    {
        myMultiDelegate += PowerUp;
        myMultiDelegate += TurnRed;

        if (myMultiDelegate!=null)
        {
            myMultiDelegate(); //如果為空的話會報錯
        }

        myMultiDelegate -= PowerUp;
        myMultiDelegate -= TurnRed;


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PowerUp() 
    {
        print("Orb is powering up!");

    }

    void TurnRed()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }

}
