using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnColorScript : MonoBehaviour
{
    private void OnEnable()
    {
        EventManager.OnClicked += TurnColor;
    }

    private void OnDisable()
    {
        EventManager.OnClicked -= TurnColor;

    }

    void TurnColor()
    {
        Color col = new Color(Random .value,Random .value,Random .value);//返回一個在0-1之間的隨機；顏色rgb三個值是在0-1之間的
        GetComponent<Renderer>().material.color = col;
    }
}
