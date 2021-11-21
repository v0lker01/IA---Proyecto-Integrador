using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform spawnPoint;

    public GameObject bullet;

    public float shootForce = 1500f;
    public float shootRate = 0.5f;

    private float shootRateTime = 0;

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            if(Time.time > shootRateTime)
            {

                GameObject newBullet;

                newBullet = Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);

                newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * shootForce);

                shootRateTime = Time.time + shootRate;

                Destroy(newBullet,5);

            }
        }
        
    }
}
