using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{

    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;

   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f;
            

    }

    void TemperatureTest() 
    {

        if (coffeeTemperature>hotLimitTemperature) 
        {
            print("coffee is too hot.");

        }
        else if(coffeeTemperature<coldLimitTemperature)
        {
            print("coffee is too cold.");
        }
        else
        {
            print("coffee is just right.");
        }


    }
}
