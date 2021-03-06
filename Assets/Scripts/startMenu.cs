﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class startMenu : MonoBehaviour {

    public Canvas exitMenu;
    public Button Achievements;
    public Button exitText;

    // Use this for initialization
    void Start()
    {
        exitMenu = exitMenu.GetComponent<Canvas>();
        Achievements = Achievements.GetComponent<Button>();
        exitText = exitText.GetComponent<Button>();
        exitMenu.enabled = false;
    }

    public void ExitPress()
    {
        exitMenu.enabled = true;
        Achievements.enabled = false;
        exitText.enabled = false;

    }

    public void NoPress()
    {
        exitMenu.enabled = false;
        Achievements.enabled = true;
        exitText.enabled = true;
    }

    public void GoToAchievements()
    {
        SceneManager.LoadScene("Achievements");
    }
    public void GoToLearnCPR()
    {
        SceneManager.LoadScene("LearnCPR");
    }
    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void ExitGame()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update () {
	
	}
}
