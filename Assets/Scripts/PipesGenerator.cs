using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesGenerator : MonoBehaviour
{
    public GameObject pipe;
    public Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GeneratePipes());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator GeneratePipes(){
        while(true){
            yield return new WaitForSeconds(4f);   //waits for 4 seconds
            float randy = Random.Range(-2f,3f); // creating random number for 'y'
            pos = new Vector3(10f,randy,0); //fixing position
            Instantiate(pipe,pos,Quaternion.identity);  // creates 'pipe' infinitely
        }
        
    }
}
