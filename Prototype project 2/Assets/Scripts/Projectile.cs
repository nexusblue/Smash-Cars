﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    public int health = 100;
    public float projectileSpd = 50.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject projectile = Instantiate(Resources.Load("Projectile"), transform.position, transform.rotation) as GameObject;

            //projectile.GetComponent<Rigidbody>().AddForce(transform.forward );
            Rigidbody projectileRB = projectile.GetComponent<Rigidbody>();
            projectileRB.velocity = transform.forward * projectileSpd;
        }
    }

    void OnTriggerEnter(Collider other) {
         if (other.tag == "Thruster")
        {
            if (health < 100)
            {
                health = health + 10;
                if (health > 100)
                {
                    health = 100;
                }

            }
            if (other.tag == "Attack")
            {
                if (health < 100)
                {
                    health = health + 10;
                    if (health > 100)
                    {
                        health = 100;
                    }
                }
            }

            if (other.tag == "Wall")
            {
                Destroy(other.gameObject);
            }
        }
    }
}
