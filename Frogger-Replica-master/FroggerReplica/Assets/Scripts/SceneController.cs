using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void MainGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void EndGame()
    {
        SceneManager.LoadScene("EndScreen");
    }

    public void RollCredits()
    {
        SceneManager.LoadScene("CreditScene");
    }

    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
