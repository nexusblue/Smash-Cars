using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuInput : MonoBehaviour
{
    public void playKartGame()
    {
        SceneManager.LoadScene("KartScene");
    }

    public void playRocketGame()
    {
        SceneManager.LoadScene("RocketKartScene");
    }

    public void QuitGame() {
        Application.Quit();
        Debug.Log("quit works");
    
    }
}
