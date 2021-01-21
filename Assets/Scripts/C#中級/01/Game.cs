using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player myPlayer = new Player();

        //myPlayer.Experience = 5000;
        //int x = myPlayer.Level;
        myPlayer.Level = 5;
        Debug.Log(myPlayer.Experience);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
