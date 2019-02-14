using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthPlayer2 : MonoBehaviour
{
	private int health = 100;


    Text text;
    public Transform P2HP;



    // Start is called before the first frame update
    void Start()
    {
        P2HP.GetComponent<Text>().text = "Player 2 Hp:" + health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        P2HP.GetComponent<Text>().text = "Player 2 Hp:" + health.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Projectile1")
        {
            Destroy(other.gameObject);
            health -= 10;
            Debug.Log(health);
        }
        if (health <= 0)
        {
            Destroy(gameObject);
            Time.timeScale = 0;
        }
    }
}
