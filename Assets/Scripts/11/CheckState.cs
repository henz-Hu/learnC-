using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckState : MonoBehaviour
{
    bool myPState,myPStateInHierarchy;
    public GameObject myObject;
     // Start is called before the first frame update
    void Start()
    {
        myPState = myObject.activeSelf;
        myPStateInHierarchy = myObject.activeInHierarchy;
    }

    // Update is called once per frame
    void Update()
    {
       if(myObject.activeSelf !=myPState )
        {

            Debug.Log("myObject.activeSelf:"+ myObject.activeSelf);
            myPState = myObject.activeSelf;
        }

        if (myObject.activeInHierarchy  != myPStateInHierarchy )
        {

            Debug.Log("myObject.activeInHierarchy:" + myObject.activeInHierarchy);
            myPStateInHierarchy  = myObject.activeInHierarchy;
        }
    }
}
