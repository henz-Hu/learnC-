using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeAndStart : MonoBehaviour
{
    //即使沒有啟用腳本，awake也能被調用，
    //references between scripts，initialization
    void Awake()
    {
        Debug.Log("Awake called"); 
    }

    // Start is called before the first frame update
    //啟用過後才會調用，且只能調用一次，重複激活並不能重複調用
    void Start()
    {
        Debug.Log("Start called"); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
