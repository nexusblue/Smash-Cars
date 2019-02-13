using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour {

    public float damageAmount = 10.0f;
    public float projectileSpd = 50.0f;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {

    }

    private void FixedUpdate()
    {
        Rigidbody projectileRB = gameObject.GetComponent<Rigidbody>();
        projectileRB.velocity = transform.forward * projectileSpd * Time.deltaTime;

    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Thruster")
        {
            /*if (health < 100)
            {
                health -= 10;
            }*/
            Destroy(other.gameObject);
        }
        if (other.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}
