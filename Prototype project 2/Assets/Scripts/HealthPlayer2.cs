using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class HealthPlayer2 : MonoBehaviour
{
	public int health = 100;


    Text text;
    public Transform P2HP;
    public GameObject P1Win;
    public GameObject GameAudio;


    // Start is called before the first frame update
    void Start()
    {
        P2HP.GetComponent<Text>().text = "Player 2 Hp:" + health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        P2HP.GetComponent<Text>().text = "Player 2 Hp:" + health.ToString();
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("MainMenu");

        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Game Quit");
        }
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
            P1Win.SetActive(true);
            GameAudio.SetActive(false);
        }
    }
}
