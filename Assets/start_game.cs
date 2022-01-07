using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start_game : MonoBehaviour
{
    public GameObject Win_window;
    public GameObject Win_Button;
    public GameObject Continue_Button;
    public void Landing_page()
    {
        SceneManager.LoadScene(0);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void HowToPlay()
    {
        SceneManager.LoadScene(2);
    }
    public void Win_Game()
    {
        SceneManager.LoadScene(3);
    }
    public void onBtn()
    {
        Win_window.SetActive(false);
        Win_Button.SetActive(false);
        Continue_Button.SetActive(false);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
