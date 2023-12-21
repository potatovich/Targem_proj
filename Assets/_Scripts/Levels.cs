using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Levels : MonoBehaviour
{
    public void PlayLevel1()
    {
        SceneManager.LoadScene("_Scene1");
    }

    public void PlayLevel2()
    {
        SceneManager.LoadScene("_Scene2");
    }

    public void PlayLevel3()
    {
        SceneManager.LoadScene("_Scene3");
    }
}
