using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public int answers;

    public void Restart()
    {
        StartCoroutine(LoadRestart());
    }

    public void QuestionOneRight()
    {
        StartCoroutine(LoadQuestionOneRight());
    }

    public void QuestionTwoRight()
    {
        StartCoroutine(LoadQuestionTwoRight());
    }

    IEnumerator LoadRestart()
    {
        answers = 0;
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("00questionOne");
    }

    IEnumerator LoadQuestionOneRight()
    {
        answers = answers + 1;
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("01questionTwo");
    }

    IEnumerator LoadQuestionTwoRight()
    {
        answers = answers + 1;
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("02answer");
    }
}