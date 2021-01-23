using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeScript9 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Humanoid9 player1 = new Humanoid9();
        Humanoid9 player2 = new Enemy9();
        Humanoid9 player3 = new Orc9();

        player1.Yell();
        player2.Yell();
        player3.Yell();

        Enemy9 player4 = new Orc9();
        player4.Yell();//和new (member hiding)不同還是會把orc裡的方法調用一邊
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class Humanoid9
{

    public virtual void Yell()
    {
        Debug.Log("I am Humanoid!");

    }
}

public class Enemy9: Humanoid9
{
    public override void Yell()
    {
        base.Yell();
        Debug.Log("I am Enemy");
    }
}

public class Orc9 : Enemy9
{
    public override void Yell()
    {
        base.Yell();
        Debug.Log("I am Orc9");
    }
}