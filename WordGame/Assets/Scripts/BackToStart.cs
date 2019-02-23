using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackToStart : MonoBehaviour {

    public Text finalScoreText;

    public void RestartGame()
    {
        SceneManager.LoadScene("MenuScreen");
    }

    private void DisplayScore()
    {
        finalScoreText.text = "Score: " + PlayerPrefs.GetInt("Player Score").ToString();
    }
}
