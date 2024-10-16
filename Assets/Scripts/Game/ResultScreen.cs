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
        loseScreen.SetActive(true);
    } 
    
    private void InitWinScreen()
    {
        winScreen.SetActive(true);
    }
}
