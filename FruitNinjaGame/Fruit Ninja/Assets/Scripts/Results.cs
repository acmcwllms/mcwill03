using UnityEngine;
using UnityEngine.UI;

public class Results : MonoBehaviour
{
    public Text FinalScore;
    public Text FinalTime;

    private void Start()
    {
        FinalScore.text = "Score: " + ScoreSystem.CurrentScore.ToString();
        FinalTime.text = "Time Played: " + ScoreSystem.timePlayed.ToString();

    }
}
