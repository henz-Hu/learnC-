using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicSyntax : MonoBehaviour
{
// Start is called before the first frame update
    void Start()
    {

        Debug.Log(transform.position.y);

        if (transform.position.y <= 5f)
        {

            Debug.Log("I'm about to hit the ground!");

        }



    }
    void Update()
    {
        if (transform.position.y <= 5f&& transform.position.y >0.5f)
        {

            Debug.Log("I'm about to hit the ground!");

        }else if (transform.position.y <= 0.5f)
       
        {


            Debug.Log("I'm on the ground!");



        }
    }
}