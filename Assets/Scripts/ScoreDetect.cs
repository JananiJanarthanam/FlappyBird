using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreDetect : MonoBehaviour
{
    private idle_bird bird;  //creating reference for Bird class.
    // Start is called before the first frame update
    void Start()
    {
        bird = GameObject.Find("idle bird").GetComponent<idle_bird>();    //find GameObject bird and copy their script idle_bird and store it in the variable.
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag=="Player"){
            bird.UpdateScore();
        }
    }
}
