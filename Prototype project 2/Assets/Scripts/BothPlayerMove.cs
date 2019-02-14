using UnityEngine;

public class BothPlayerMove : MonoBehaviour
{
    public Vector3 forward;
    Rigidbody PlayerRb;
    public float speed = 3.0f;
    public static float spdMultPos = 1.25f;
    public float spdMultNeg = .75f;
    public float rotateSpeed = 15;
    public float pushDown = 15;


    // Use this for initialization
    void Start()
    {

        PlayerRb = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag == "Player")
        {
            CheckWASDInput();
        }

        if (gameObject.tag == "Player2")
        {
            CheckArrowInput();
        }


    }

    private void FixedUpdate()
    {
        transform.position += Vector3.down * pushDown * Time.deltaTime;
    }

    private void CheckWASDInput()
    {
        if (Input.GetKey(KeyCode.A))
        {
            //transform.Rotate(0,0,rotateSpeed * Time.deltaTime) ;
            transform.Rotate(Vector3.down, rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
        }
        //Test for speed booster
        if (Input.GetKey(KeyCode.W))
        {
            PlayerRb.velocity = transform.forward * speed * spdMultPos;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            PlayerRb.velocity = transform.forward * speed * spdMultNeg;
        }
        else
        {
            PlayerRb.velocity = transform.forward * speed;
        }
        //Debug.Log("Player1 Speed: " + PlayerRb.velocity.z);

    }

    private void CheckArrowInput()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //transform.Rotate(0,0,rotateSpeed * Time.deltaTime) ;
            transform.Rotate(Vector3.down, rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
        }
        //Test for speed booster
        if (Input.GetKey(KeyCode.UpArrow))
        {
            PlayerRb.velocity = transform.forward * speed * spdMultPos;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            PlayerRb.velocity = transform.forward * speed * spdMultNeg;
        }
        else
        {
            PlayerRb.velocity = transform.forward * speed;
        }
        //Debug.Log("Player2 Speed: " + PlayerRb.velocity.z);

    }

}