using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour {
    private static string[] wordList =
    {
        "main", "int", "char", "double", "class", "struct", "cout", "public", "void",
        "string", "private", "bool", "float", "vector", "return", "break", "include", 
        "iostream", "namespace", "cin", "while", "list", "const", "endl",
        "getline"

    };


    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;

    }
}
