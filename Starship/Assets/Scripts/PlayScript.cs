using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayScript : MonoBehaviour
{
    public static PlayScript instance;
    [SerializeField]
    private GameObject asteroidPrefab;
    [SerializeField]
    private GameObject rocketPrefab;
    [SerializeField]
    private TextMeshPro scoreText; 
    [SerializeField]
    private TextMeshPro lifeText;
    private Vector2 screenWH;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("score", 0);
        screenWH = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(AsteroidWave());

        if(instance == null){
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpwanEnemy(){
        GameObject gameObject = Instantiate(asteroidPrefab) as GameObject;
        gameObject.transform.position = new Vector2(Random.Range(-screenWH.y , screenWH.y), screenWH.x * 1.5f);
    }

    IEnumerator AsteroidWave(){
        while(true){
            yield return new WaitForSeconds(1.0f);
            SpwanEnemy();
        }
    }

    public void updateScoreText(){
        score += 1;
        scoreText.text = "Your Score: " + score.ToString();
        PlayerPrefs.SetInt("score", score);
    }

    public void updateLifeText(int value){
        lifeText.text = "Life: " + value.ToString();
    }
}
