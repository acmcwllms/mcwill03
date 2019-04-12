using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {

	public static int CurrentScore = 0;
    public static int CurrentLives = 3;

	public Text scoreText;
    public Text livesText;

	void Start ()
	{
		scoreText.text = CurrentScore.ToString();
        livesText.text = "Lives: " + CurrentLives.ToString();
	}

    private void Update()
    {
        if (CurrentLives == 0)
        {
            SceneManager.LoadScene("EndScreen");
        }
    }

}
