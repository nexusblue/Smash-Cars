using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUp : MonoBehaviour {

    public AudioClip coinClip;
    public AudioSource coinSource;

    public float speedUp = 0.1f; 

	// Use this for initialization
	void Start () {
        coinSource.clip = coinClip;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        //Check for if tag is player one or two first
        
        if (other.tag == "Coin" && gameObject.tag == "Player")
        {
            coinSource.Play();
            Destroy(other.gameObject);
            PlayerMovement.spdMultPos += speedUp;
            Instantiate(Resources.Load("CoinEffect"), other.transform.position, other.transform.rotation);

        }
        if (other.tag == "Coin" && gameObject.tag == "Player2")
        {
            Destroy(other.gameObject);
            PlayerMove2.spdMultPos += speedUp;
            Instantiate(Resources.Load("CoinEffect"), other.transform.position, other.transform.rotation);


        }
    }

}
