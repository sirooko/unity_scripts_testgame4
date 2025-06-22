using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public void OnPressPlayAgain()
    {
        SceneManager.LoadScene("GameMenu");
    }
    public void OnPressMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    
}
