using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUp : MonoBehaviour {

    public float speedUp = 0.1f; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        //Check for if tag is player one or two first
        
        if (other.tag == "Coin" && gameObject.tag == "Player")  {
            Destroy(other.gameObject);
            PlayerMovement.spdMultPos += speedUp;
            Instantiate(Resources.Load("CoinEffect"));

        }
        if (other.tag == "Coin" && gameObject.tag == "Player2")
        {
            Destroy(other.gameObject);
            PlayerMove2.spdMultPos += speedUp;
            Instantiate(Resources.Load("CoinEffect"));


        }
    }

}
