using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    public float nextTimeToFire = 1f;
    public float fireRate = 15f ;

    // Update is called once per frame
    void Update () {

        if (gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.Space) && (Time.time >= nextTimeToFire))  
            {
                nextTimeToFire = Time.time + 1f / fireRate;
                GameObject projectile = Instantiate(Resources.Load("P1_Projectile"), transform.position, transform.rotation) as GameObject;

                //projectile.GetComponent<Rigidbody>().AddForce(transform.forward );

            }

        }


        if (gameObject.tag == "Player2") {
            if (Input.GetKeyDown(KeyCode.RightShift) && (Time.time >= nextTimeToFire))
            {
                nextTimeToFire = Time.time + 1f / fireRate;
                GameObject projectile = Instantiate(Resources.Load("P2_Projectile"), transform.position, transform.rotation) as GameObject;

                //projectile.GetComponent<Rigidbody>().AddForce(transform.forward );

            }

        }

    }


}
