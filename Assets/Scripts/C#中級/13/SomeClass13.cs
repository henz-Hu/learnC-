using System.Collections;
using System.Collections.Generic;//要用List就需要這個命名空間
using UnityEngine;

public class SomeClass13 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<BadGuy> badGuys = new List<BadGuy>();

        badGuys.Add(new BadGuy("Harvey",50));
        badGuys.Add(new BadGuy("Magneto",100));
        badGuys.Add(new BadGuy("Pip",5));


        //badGuys[0];
        //badGuys.Insert(new BadGuy("  ",0));
        //int a = badGuys.Count;
        //badGuys.Remove(badGuys [0]);
        //badGuys.RemoveAt(0);
        badGuys.Sort();//可以結合system的Incomparable接口來排序，需要在類中引用這個接口
       
         foreach (BadGuy guy in badGuys)
        {
            print(guy.name+"  "+guy.power);
        }
        badGuys.Clear();//清除列表
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
