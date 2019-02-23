using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WordManager : MonoBehaviour {

    public List<Word> words;
    private bool hasActiveWord;
    private Word activeWord;
    public WordSpawner wordSpawner;

    public int pointsForCompletedWord = 10;
    public Text scoreText;
    private int playerScore;
    public float timeLimitInSeconds;
    public Text timeText;
    public Text finalScoreText;

    public GameObject canvasObject1;
    public GameObject canvasObject2;

    private void Start()
    {
        playerScore = 0;
        timeLimitInSeconds = 30;
    }

    public void AddWord()
    {

        Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
        Debug.Log(word.word);

        words.Add(word);
    }

    public void TypeLetter(char letter)
    {
        if(hasActiveWord)
        {
            if(activeWord.GetNextLetter() == letter)
            {
                activeWord.TypeLetter();
            }
        }
        else
        {
            foreach(Word word in words)
            {
                if(word.GetNextLetter() == letter)
                {
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    break;
                }
            }
        }

        if(hasActiveWord && activeWord.WordTyped())
        {
            hasActiveWord = false;
            words.Remove(activeWord);
            playerScore += pointsForCompletedWord;
            scoreText.text = "Score: " + playerScore.ToString();
            PlayerPrefs.SetInt("Player Score", playerScore);
        }
    }

    public void EndRound()
    {
        canvasObject1.SetActive(false);
        canvasObject2.SetActive(true);
    }

    private void UpdateTimeLimit()
    {
        timeText.text = "Time: " + Mathf.Round(timeLimitInSeconds).ToString();
    }

    private void Update()
    {
        if (timeLimitInSeconds > 0f)
        {
            timeLimitInSeconds -= Time.deltaTime;
            UpdateTimeLimit();
        }
        else
        {
            finalScoreText.text = "Score: " + playerScore.ToString();
            EndRound();
        }

    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("MenuScreen");
    }

}
