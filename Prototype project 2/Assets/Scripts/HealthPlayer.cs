using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthPlayer : MonoBehaviour
{
    private int health = 100;

    Text text;
    public Transform P1HP;

    // Start is called before the first frame update
    void Start()
    {
        P1HP.GetComponent<Text>().text = "Player 1 Hp:" + health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        P1HP.GetComponent<Text>().text = "Player 1 Hp:" + health.ToString();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Projectile2")
        {
            Destroy(other.gameObject);
            health -= 10;
            Debug.Log(health);
            if (health <= 0)
            {
                Destroy(gameObject);
                Time.timeScale = 0;
            }

        }
    }
}
