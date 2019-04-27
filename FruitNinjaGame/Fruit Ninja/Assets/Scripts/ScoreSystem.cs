using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreSystem : MonoBehaviour
{
    public static int CurrentScore;
    public static float timePlayed;

    public Text scoreText;
    public Text timeText;

    void Start()
    {
        CurrentScore = 0;

    }

    private void Update()
    {
        timePlayed += Time.deltaTime;
        scoreText.text = "Score: " + CurrentScore.ToString();
        timeText.text = "Time Played: " + timePlayed.ToString();

        if (timePlayed >= 20f) 
        {
            SceneManager.LoadScene("4 End Screen");
        }
    }
}
