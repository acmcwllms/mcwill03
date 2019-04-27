using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class ReadScores : MonoBehaviour
{
    public Text HighScores;
    public int numScores = 5;

    // Start is called before the first frame update
    void Start()
    {
        string path = "Assets/scores.txt";
        string line;
        string[] fields;
        string[] playerNames = new string[numScores];
        int[] playerScores = new int[numScores];
        int scoresRead = 0;

        HighScores.text = "";

        StreamReader reader = new StreamReader(path);
        while (!reader.EndOfStream && scoresRead < numScores)
        {
            line = reader.ReadLine();
            fields = line.Split(',');
            HighScores.text += fields[0] + " : " + fields[1] + "\n";
            scoresRead += 1;
        }
    }

}
