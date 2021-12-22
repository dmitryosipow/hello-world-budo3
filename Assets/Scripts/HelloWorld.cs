using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    [SerializeField] private int min;
    [SerializeField] private int max;
    private int guess;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"Guess number from {min} to {max}");
        CalculateGuess();
    }

    // Update is called once per frame
    void Update()
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
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Victory");
        }
    }

    private void CalculateGuess()
    {
        guess = (min + max) / 2;
        Debug.Log($"Is your number {guess}");
    }
}
