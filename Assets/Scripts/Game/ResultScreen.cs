using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultScreen : MonoBehaviour
{
    [SerializeField] private GameObject winScreen;
    [SerializeField] private GameObject loseScreen;

    private void Start()
    {
        GameManager.GetInstance().OnLose += InitLoseScreen;
        GameManager.GetInstance().OnWin += InitWinScreen;
    }

    private void InitLoseScreen()
    {
        Time.timeScale = 0f;
        loseScreen.SetActive(true);
    } 
    
    private void InitWinScreen()
    {
        Time.timeScale = 0f;
        winScreen.SetActive(true);
    }
}
