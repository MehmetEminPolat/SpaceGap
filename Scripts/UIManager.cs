using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour
{
    public static UIManager uIManager;
    public Transform inGameMenuPanel;
    public Transform gameOverMenu;
    public Transform startPanel;
    public Button pauseButton,resumeButton,againGameButton,startButton;
    public Text rocketCount;

    private void Start()
    
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (sceneIndex!=0)
        {
            Time.timeScale = 1f;
            pauseButton.onClick.AddListener(OpenInGameMenu);
            resumeButton.onClick.AddListener(CloseInGameMenu);
            againGameButton.onClick.AddListener(AgainGame);
        }
        else
        {
            startButton.onClick.AddListener(CloseStartMenu);
            Time.timeScale = 0f;
        }
       
    }

    private void Update()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (sceneIndex==1)
        {
            rocketCount.text = RocketController.rocketCount.ToString();
        }
        
    }
 
    private void OpenInGameMenu()
    {
        Time.timeScale = 0;
        inGameMenuPanel.gameObject.SetActive(true);
        
    }

    private void CloseInGameMenu()
    {
        Time.timeScale = 1f;
        inGameMenuPanel.gameObject.SetActive(false);
      
    }
    
    private void CloseStartMenu()
    {
        
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sceneIndex + 1);
        gameObject.SetActive(false);

    }
    public void OpenGameOverMenu()
    {
        Time.timeScale = 0f;
        gameOverMenu.gameObject.SetActive(true);
      
    }

    private void AgainGame()
    {
        RocketController.rocketCount = 20;
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
        
    }

  

    
   
    


    
}
