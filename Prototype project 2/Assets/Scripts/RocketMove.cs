using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMove : MonoBehaviour
{
    public Vector3 forward;
    Rigidbody PlayerRb;
    public float speed = 3.0f;
    public static float spdMultPos = 1.25f;
    public float spdMultNeg = .5f;
    public float rotateSpeed = 90;

    // Use this for initialization
    void Start(){
        PlayerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update(){

        if (gameObject.tag == "Player"){
            CheckWASDInput();
        }
        if (gameObject.tag == "Player2"){
            CheckArrowInput();
        }

    }


    private void CheckWASDInput()
    {
        if (Input.GetKey(KeyCode.A)){
            //transform.Rotate(0,0,rotateSpeed * Time.deltaTime) ;
            transform.Rotate(Vector3.down, rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D)){
            transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
        }
        //Test for speed booster
        if (Input.GetKey(KeyCode.W)){
            transform.Rotate(Vector3.left, rotateSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S)){
            transform.Rotate(Vector3.right, rotateSpeed * Time.deltaTime);
        }
        else{
            PlayerRb.velocity = transform.forward * speed;
        }

    }
    private void CheckArrowInput()
    {
        if (Input.GetKey(KeyCode.J)){
            transform.Rotate(Vector3.down, rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.L)) {
            transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
        }
        //Test for speed booster
        if (Input.GetKey(KeyCode.I))
        {
            transform.Rotate(Vector3.left, rotateSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.K))
        {
            transform.Rotate(Vector3.right, rotateSpeed * Time.deltaTime);
        }
        else
        {
            PlayerRb.velocity = transform.forward * speed;
        }
    }

}
