using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockInteractions : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    private bool test = false;
    private bool scored = false;
    public AudioSource scream;
    public HUDScript hudCanvas;
    // Start is called before the first frame update
    void Start()
    {

        rigidBody = this.GetComponent<Rigidbody2D>();
        rigidBody.gravityScale = 1.0f;
        GetComponent<AudioSource>().playOnAwake = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && !test)
        {
            rigidBody.gravityScale = 1.0f;
            transform.parent = null;
            test = true;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)  //Plays Sound Whenever collision detected
    {
        if (collision.gameObject.tag == "vict" && !scored)
        {
            scream = GetComponent<AudioSource>();
            scream.Play();
            hudCanvas.IncrimentScore();
            scored = true;
        }
    }
}
