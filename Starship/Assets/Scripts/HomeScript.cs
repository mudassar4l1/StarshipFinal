﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGameButtonClicked(){
        SceneManager.LoadScene("PlayScene");
    }

    public void ExitGameButtonClicked(){
        Application.Quit();
    }
}
