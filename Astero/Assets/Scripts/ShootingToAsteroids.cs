using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShootingToAsteroids : MonoBehaviour {

    
    public float fireRate = 0.5f;
   
    public GameObject bulletsParent;
    public GameObject bulletPrefab;
    public Transform gun;
    
    public bool shootingIsActive = false;

    public ForceMode2D forceMode;
    public float bulletForce = 25f;

    void Start()
    {
        InvokeRepeating("Shoot",0.5f, 0.5f);
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //Shoot();
            
        }
    }


    void Shoot()
    {

        GameObject bullet = Instantiate(bulletPrefab, gun.transform.position, gun.transform.rotation);
        Rigidbody2D rb2D = bullet.GetComponent<Rigidbody2D>();
        rb2D.AddForce(gun.up * bulletForce, forceMode);
        bullet.transform.parent = bulletsParent.transform;

    }

}
