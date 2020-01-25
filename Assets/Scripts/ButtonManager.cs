using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void LoadGameplayScene()
    {
        SceneManager.LoadScene(2);
    }
    
    public void LoadSettingScene()
    {
        SceneManager.LoadScene(1);
    }
    
    public void LoadMenuScene()
    {
        SceneManager.LoadScene(0);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            LoadMenuScene();
        }
    }
}
