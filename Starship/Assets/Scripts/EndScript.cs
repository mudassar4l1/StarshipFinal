using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        int score = PlayerPrefs.GetInt("score");
        scoreText.text = "Your Score is:   " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayAgainButtonClicked(){
        SceneManager.LoadScene("PlayScene");
    }

    public void ExitGameButtonClicked(){
        Application.Quit();
    }
}
