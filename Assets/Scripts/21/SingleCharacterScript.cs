using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleCharacterScript : MonoBehaviour
{
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


        }
    }

    public Stuff myStuff = new Stuff(10,7,25);
    public float speed;
    public float turnSpeed;
    public Rigidbody projectileAPrefab;
    public Transform firstPosition;
    public float bulletSpeed;

    void Update()
    {

    }

    void Movement()
    { }

    void Shoot()
    { }
}
