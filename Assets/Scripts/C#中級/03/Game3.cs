using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Enemy enemy1 = new Enemy();
        Enemy enemy2 = new Enemy();
        Enemy enemy3 = new Enemy();

        int x = Enemy.enemyCount;//靜態變量不需要實例化就可以使用
        Debug.Log(x);

       
        Debug.Log(Player3 .playerCount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
