using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadQuestionOne()
    {
        SceneManager.LoadScene("00questionOne");
    }

    public void LoadQuestionTwo()
    {
        SceneManager.LoadScene("01questionTwo");
    }

    public void LoadAnswer()
    {
        SceneManager.LoadScene("02answer");
    }
}