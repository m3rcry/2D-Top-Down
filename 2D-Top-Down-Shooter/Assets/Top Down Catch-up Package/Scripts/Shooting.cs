using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Fix this script 
//Add this script to your player so you can fire bullets

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    public GameObject firePoint;
    public float damageAmount, attackRange;
    public LayerMask enemyLayer;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot(){
        GameObject clone = Instantiate(bullet, firePoint.transform.position, firePoint.transform.rotation);
        }
}
