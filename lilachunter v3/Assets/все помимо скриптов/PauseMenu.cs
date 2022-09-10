using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField]
    Canvas Player;    
    public bool PauseGame;
    public GameObject pauseGameMenu;

     void Update()
     {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PauseGame)
            {
                Resume();
               
            }
            else 
            {
                
                Pause();
            }
           
        }
     }

    public void Resume()
    {
        pauseGameMenu.SetActive(false);
        Time.timeScale = 1f;
        PauseGame = false;
        if (PauseGame == false)
        {
            Player.gameObject.SetActive(true);
        }
    }

    public void Pause()
    {
        pauseGameMenu.SetActive(true);
        Time.timeScale = 0f;
        if (pauseGameMenu == true)
        {
            Player.gameObject.SetActive(false);
        }
        else if (pauseGameMenu == false)
        {
            Player.gameObject.SetActive(true);
        }
    }

    public void LosdMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}
