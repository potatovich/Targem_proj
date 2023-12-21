using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameButtons : MonoBehaviour
{
    public void RepeatLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("_Scene0");
        Time.timeScale = 1;
    }
}
