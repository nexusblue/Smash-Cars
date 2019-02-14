using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {



	// Update is called once per frame
	void Update () {

        if (gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GameObject projectile = Instantiate(Resources.Load("P1_Projectile"), transform.position, transform.rotation) as GameObject;

                //projectile.GetComponent<Rigidbody>().AddForce(transform.forward );

            }

        }


        if (gameObject.tag == "Player2") {
            if (Input.GetKeyDown(KeyCode.RightShift))
            {
                GameObject projectile = Instantiate(Resources.Load("P2_Projectile"), transform.position, transform.rotation) as GameObject;

                //projectile.GetComponent<Rigidbody>().AddForce(transform.forward );

            }

        }

    }


}
