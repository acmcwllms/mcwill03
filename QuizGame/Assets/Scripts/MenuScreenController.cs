using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuScreenController : MonoBehaviour {

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }
}
