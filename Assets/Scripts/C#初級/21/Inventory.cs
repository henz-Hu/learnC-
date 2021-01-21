using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    //子類
    public class Stuff
    {
        public int projectileA;
        public int projectileB;
        public int projectileC;
        public float fuel;
        public Stuff(int prA, int prB, int prC)
        {
            projectileA = prA;
            projectileB = prB;
            projectileC = prC;
        }//傳入參數的時候構造函數的附值規則


        public Stuff(int prA,float fu)
        {
            projectileA = prA;
            fuel = fu;
        }//ctor+雙擊tab快速生成構造函數


        public Stuff()
        {
            projectileA = 1;
            projectileA = 1;
            projectileA = 1;
        }//構造函數的默認值，不傳入參數的時候

        //1構造函數的名稱始終要和類的名稱保持一致；2構造函數一定不會有返回類型，連void都沒有；3一個類可能有多個不同的構造函數，但對象初始化時
        //只會調用其中一個構造函數
    }
    //創造一個stuff類的對象 creating an instance（an object）of the stuff class
    public Stuff myStuff = new Stuff(50,5,5);

    public Stuff myOtherStuff = new Stuff(50,1.5f);
    void Start()
    {
        Debug.Log(myStuff.projectileA);
    }


}
