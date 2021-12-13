using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    private Vector2 screenWH;
    private float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = this.GetComponent<Rigidbody2D>();
        //rigidbody2D.velocity = new Vector2(0, -speed);
        screenWH = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < screenWH.y){
            //Destroy(this.gameObject);
        }

        MoveAsteroid();
    }
    private void MoveAsteroid(){
        Vector3 temp = transform.position;
        temp.y -= speed * Time.deltaTime;
        if(temp.y < -6){
            PlayScript.instance.updateScoreText();
            Destroy(this.gameObject);
        }

        transform.position = temp;
    }

    private void OnTriggerEnter2D(Collider2D other){
        Debug.Log("Asteroid Hit Detected");
        Destroy(this.gameObject);
    }
}
