using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using UnityEditor;

public class HighScores : MonoBehaviour
{
    public Text HighScoresList;
    public int numScores = 5;
    public InputField PlayerName;

    private void Start()
    {
        DisplayTopScores();
    }

    public void DisplayTopScores()
    {
        string path = "Assets/scores.txt";
        string line;
        string[] fields;
        string[] players = new string[numScores];
        int[] scores = new int[numScores];
        int scoresWritten = 0;

        bool NewScore = false;
        string newName = "No name entered";
        int newScore = ScoreSystem.CurrentScore;
        string[] writeNames = new string[5];
        string[] writeScores = new string[5];

        HighScoresList.text = "";
        newName = PlayerName.text;


        StreamReader rd = new StreamReader(path);
        while(!rd.EndOfStream)
        {
            line = rd.ReadLine();
            fields = line.Split(',');

            if(!NewScore && scoresWritten < numScores)
            {
                if(newScore > Convert.ToUInt32(fields[1]))
                {
                    HighScoresList.text = newName + " : " + newScore + "\n";
                    writeNames[scoresWritten] = newName;
                    writeScores[scoresWritten] = newScore.ToString();
                    NewScore = true;
                    scoresWritten += 1; 
                }
            }
            if(scoresWritten < numScores)
            {
                HighScoresList.text += fields[0] + " : " + fields[1] + "\n";
                writeNames[scoresWritten] = fields[0];
                writeScores[scoresWritten] = fields[1];
                scoresWritten += 1;
            }

        }
        rd.Close();

        StreamWriter sw = new StreamWriter(path);
        for (int i = 0; i < scoresWritten; i++)
        {
            sw.WriteLine(writeNames[i] + ',' + writeScores[i]);
        }
        sw.Close();

        AssetDatabase.ImportAsset(path);
        TextAsset asset = (TextAsset)Resources.Load("scores");
    }
}
