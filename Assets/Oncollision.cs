using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oncollision : MonoBehaviour
{
    public AudioSource scream;
    // Start is called before the first frame update
    void Start()
    {

        GetComponent<AudioSource>().playOnAwake = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)  //Plays Sound Whenever collision detected
    {
        if(collision.gameObject.tag =="Rock")
        {
            scream = GetComponent<AudioSource>();
            scream.Play();
        }
        
    }
}
