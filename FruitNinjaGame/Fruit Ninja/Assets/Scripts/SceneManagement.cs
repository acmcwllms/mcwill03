using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public void EnterGame()
    {
        SceneManager.LoadScene("2 Entry Screen");
    }

    public void StopPlaying()
    {
        SceneManager.LoadScene("4 End Screen");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("1 Intro Screen");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("3 Game Screen");
    }

    public void EndGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
