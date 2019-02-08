using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Vector3 forward;
    Rigidbody PlayerRb ;
    public float speed = 3.0f;
    public float spdMultPos = 1.5f;
    public float spdMultNeg = .75f;
    public float rotateSpeed = 15;

	// Use this for initialization
	void Start () {

        PlayerRb = GetComponent<Rigidbody>();
        
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.A)){
            //transform.Rotate(0,0,rotateSpeed * Time.deltaTime) ;
            transform.Rotate(Vector3.down, rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D) ) {
            //transform.Rotate(0,0,rotateSpeed * Time.deltaTime) ;
            transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
        }
        //Test for speed booster
        if (Input.GetKey(KeyCode.W)){
            //transform.Rotate(0,0,rotateSpeed * Time.deltaTime) ;
            PlayerRb.velocity = transform.forward * speed * spdMultPos;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            //transform.Rotate(0,0,rotateSpeed * Time.deltaTime) ;
            PlayerRb.velocity = transform.forward * speed * spdMultNeg;
        }
        else
        {
            //transform.Rotate(0,0,rotateSpeed * Time.deltaTime) ;
            PlayerRb.velocity = transform.forward * speed;
        }
        Debug.Log("Speed is " + PlayerRb.velocity);



    }
}
