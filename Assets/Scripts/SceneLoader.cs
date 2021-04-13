using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadWelcomeScene()
    {
        SceneManager.LoadScene("00questionOne");
    }

    public void LoadColorScene()
    {
        SceneManager.LoadScene("01questionTwo");
    }

    public void LoadNumberScene()
    {
        SceneManager.LoadScene("02answer");
    }
}