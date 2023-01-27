using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class idle_bird : MonoBehaviour
{
    public Text scoreText;  //using UnityEngine.UI; This library must be used for using this class.
    public float score;
    private Rigidbody2D rb;
    public float jumpforce;
    // Start is called before the first frame update
    void Start()
    {
        score=0;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            rb.velocity = new Vector2(rb.velocity.x,jumpforce);
        }
    }

    void OnCollisionEnter2D(Collision2D other){  //This function is called whenever bird hits in an object
        if(other.gameObject.tag=="pipe"){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); //Loads the game from the initial stage (game starts from first) ->using UnityEngine.SceneManagement; This library must be used for using this class.
        }
    }

    public void UpdateScore(){
        score++;
        //score = score + 0.5f;
        scoreText.text = score.ToString();  // scoreText can only store strings. So converting the value to a string.
    }
}
