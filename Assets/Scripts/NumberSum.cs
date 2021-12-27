using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NumberSum : MonoBehaviour
{
    private int sum;
    private int SUM_MAX = 50;
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
            
            int num = GetPressedNumber();

            if (num >= 0)
            {
                sum += num;
                turnsNum++;
                logger.text = $"Sum is {sum}, turns total is {turnsNum}";
            }
            
            if (sum >= SUM_MAX)
            {
                gameStatus = "FINISHED";
                logger.text = $"Victory, sum is {sum}, turns total is {turnsNum}. Press space to restart";
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (gameStatus == "FINISHED")
            {
                Init();
                return;
            }

        }
    }

    private void Init()
    {
        gameStatus = "PLAY";
        turnsNum = 0;
        sum = 0;
        logger.text = "Press num from 1 till 9";
    }
    
    private int GetPressedNumber() {
        for (int number = 1; number <= 9; number++)
        {
            string numStr = number.ToString();
            
            if (Input.GetKeyDown(numStr) || Input.GetKeyDown($"[{numStr}]"))
            {
                return number;
            }
        }
        
        return -1;
    }
}
