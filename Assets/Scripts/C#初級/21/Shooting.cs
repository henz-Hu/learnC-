using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    //public Stuff myStuff = new Stuff(10, 7, 25);
    Inventory a = new Inventory();
    //public float speed;
    //public float turnSpeed;
    public Rigidbody projectileAPrefab;
    public Transform firePosition;
    public float bulletSpeed;
    void Start()
    {
     
          a = GetComponent<Inventory>();
          a.myStuff = new Inventory.Stuff(10, 7, 25);
    }

    // Update is called once per frame
    void Update()
    {
        Shoot(); 
    }
    void Shoot()
    {
        if (Input.GetButtonDown("Fire1") && a.myStuff.projectileA > 0)
        {
            Rigidbody projectileAInstance = Instantiate(projectileAPrefab, firePosition.position, firePosition.rotation) as Rigidbody;
            projectileAInstance.AddForce(firePosition.forward * bulletSpeed);
            //myStuff.projectileA--;
            a.myStuff.projectileA--;

        }
    }
}
