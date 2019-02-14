using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPlayer2 : MonoBehaviour
{
	private int health = 100; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
