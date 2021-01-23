using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avatar : MonoBehaviour,IKillable,IDamageable <float>//public class Avatar : IKillable,IDamageable
{
    public void Kill()
    {
        Debug.Log("Killed");
    }

    public void Damage(float a)
    {
        Debug.Log("Damaged"+a);
    }

     void Start()
    {
        Kill();
        Damage(0.5f);
    }

   
}
