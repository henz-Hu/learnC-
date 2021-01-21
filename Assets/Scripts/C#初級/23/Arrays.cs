using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{

    int[] myIntArray = new int[5];
    //int[]myIntArray={};
    // Start is called before the first frame update
    public GameObject[] players;//可以再inspector裡面初始化。
    void Start()
    {
        players = GameObject.FindGameObjectsWithTag("Player");//這樣也可以完成上述的初始化，並且不需要聲明長度

        for (int i=0;i<players.Length;i++) 
        {
            Debug.Log("Player Number "+i+" is named "+players[i].name);
        }
    }

   
}
