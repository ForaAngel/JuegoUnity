﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
        public string nextSceneName; // Name of the next scene to load

    public void B_LoadScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }


    public void B_QuitGame()
    {
        Application.Quit();
    }
}
