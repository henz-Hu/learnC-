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
    public Transform firePosition;
    public float bulletSpeed;

    void Update()
    {
        Movement();
        Shoot();

    }

    void Movement()
    {
        float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        transform.Translate(Vector3.forward*forwardMovement);
        transform.Rotate(Vector3.up*turnMovement);  

    }

    void Shoot()
    { 
    if(Input.GetButtonDown ("Fire1")&&myStuff.projectileA>0)
    {
            Rigidbody projectileAInstance = Instantiate(projectileAPrefab,firePosition.position,firePosition.rotation )as Rigidbody;
            projectileAInstance.AddForce(firePosition.forward*bulletSpeed);
            myStuff.projectileA--;
    }
    }
}
