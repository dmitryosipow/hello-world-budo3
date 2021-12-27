using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MagicNumbers : MonoBehaviour
{
    [SerializeField] private int min;
    [SerializeField] private int max;
    private int guess;
    private int turnsNum;
    private string gameStatus;

    [SerializeField] private Text logger;
    
    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameStatus == "PLAY")
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                max = guess;
                CalculateGuess();
            }
        
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                min = guess;
                CalculateGuess();
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (gameStatus == "INIT")
            {
                gameStatus = "PLAY";
                CalculateGuess();
                return;
            }
            
            if (gameStatus == "PLAY")
            {
                logger.text = $"Victory, your number is {guess}, turns total is {turnsNum}";
                gameStatus = "FINISHED";
                return;
            }
            
            if (gameStatus == "FINISHED")
            {
                SceneManager.LoadScene("Scenes/MagicNumbers");
                Init();
                return;
            }

        }
    }

    private void Init()
    {
        gameStatus = "INIT";
        turnsNum = 0;
        logger.text = $"Guess number from {min} to {max}";
    }

    private void CalculateGuess()
    {
        turnsNum++;
        guess = (min + max) / 2;
        logger.text = $"Is your number {guess}, turns total is {turnsNum}";
    }
}
