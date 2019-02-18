using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class HealthPlayer : MonoBehaviour
{
    public int health = 100;

    Text text;
    public Transform P1HP;
    public GameObject P2Win;
    public GameObject GameAudio;

    // Start is called before the first frame update
    void Start()
    {
        P1HP.GetComponent<Text>().text = "Player 1 Hp:" + health.ToString();



}

// Update is called once per frame
void Update()
    {
        P1HP.GetComponent<Text>().text = "Player 1 Hp:" + health.ToString();
        if (Input.GetKeyDown(KeyCode.Return)) {
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
        if (other.tag == "Projectile2")
        {
            Destroy(other.gameObject);
            health -= 10;
            Debug.Log(health);
            if (health <= 0)
            {
                Destroy(gameObject);
                P2Win.SetActive(true);
                GameAudio.SetActive(false);
                //Time.timeScale = 0;

            }

        }
    }


}
