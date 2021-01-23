using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherClass13 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Dictionary<string, BadGuy> badguys = new Dictionary<string, BadGuy>();//kvp
        BadGuy bg1 = new BadGuy("Harvey",50);
        BadGuy bg2 = new BadGuy("Magneto",100);

        badguys.Add("gangster",bg1);
        badguys.Add("mutant",bg2);

        BadGuy magneto = badguys["mutant"];//直接通過key找到需要的Value

       
          //如果不確定要找的key在不在dic裡，可以通過下面的結構查找。但是會比直接通過key找value要來的慢
        BadGuy temp = null;

        if(badguys.TryGetValue ("birds",out temp))//如果查找到了就直接把查找到的結果附值給了temp
        {
            //success!
            Debug.Log(temp.name+" "+temp.power);
        }
        else 
        {
            //failure
            Debug.Log("error");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
