using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public int health = 100;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other) {
         if (other.tag == "Defense")
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
        }
    }
}
