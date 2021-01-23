using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeScript8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Humanoid player1 = new Enemy8();
        Humanoid player2 = new Orc();
        Humanoid player3 = new Humanoid();

        player1.Yell();
        player2.Yell();
        player3.Yell();
        //因為用的都是new，聲明變量時都是最初的父級，所以只能調用到父級的Yell方法，這和virtual 和override的正好相反
        //這是自上而下向下遞減

        Enemy8  player4 = new Orc ();
        player4.Yell();//Enemy8裡的yell方法

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class Humanoid
{
  public  void Yell()
    {
        Debug.Log("Playing audio clip");
    }
}

public class Enemy8:Humanoid
{
  public  new void Yell()
    {
        Debug.Log("Change material color to yellow.");
    }
}
public class Orc:Enemy8
{
   public new void Yell()
    {
        Debug.Log("Set nav mesh to Northern Shetland Isle");
    }
}