using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Build_A_Baddie : MonoBehaviour
{
    //Put your own functions here!
    public BadGuyBrain badGuyBrain;

    public GameObject Bullet;
    public Transform bulletPos;

    private float timer;

    private void Start()
    {
        badGuyBrain = GetComponent<BadGuyBrain>();
    }

    private void Update()
    {

        timer += Time.deltaTime;
        
        if (timer > 2)
        {

            timer = 0;
            shoot();
        
        }

        void shoot()
        {
            Instantiate(Bullet, bulletPos.position, Quaternion.identity);
           
        }

    }

    
}
