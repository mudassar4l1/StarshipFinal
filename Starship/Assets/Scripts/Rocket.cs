using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rocket : MonoBehaviour
{
    private int life = 3;
    private float speed = 5f;
    private float minX = -10.0f, maxX = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxisRaw("Horizontal") > 0f){
            Vector3 temp = transform.position;
            temp.x += speed * Time.deltaTime;
            if(temp.x > maxX){
                temp.x = maxX;
            }

            transform.position = temp;
        }
        else if(Input.GetAxisRaw("Horizontal") < 0f){
            Vector3 temp = transform.position;
            temp.x -= speed * Time.deltaTime;
            if(temp.x < minX){
                temp.x = minX;
            }

            transform.position = temp;
        }
    }

    private void OnTriggerEnter2D(Collider2D other){
        Debug.Log("Rocket Hit Detected");
        life -= 1;
        PlayScript.instance.updateLifeText(life);
        if(life <= 0){
            SceneManager.LoadScene("EndScene");
        }
        //Destroy(this.gameObject);
    }
}
