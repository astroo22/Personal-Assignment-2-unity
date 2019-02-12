using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
    public float speed = 2.5f;
    //private CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        //ontroller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
   
        Vector3 playerPos = transform.position;

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetAxis("Horizontal") == -1)
        {
            if(playerPos.x >= -4.20f )
            {
                transform.position += Vector3.left * speed * Time.deltaTime;
            }
           
        }
        if (Input.GetKey(KeyCode.RightArrow)||Input.GetAxis("Horizontal") == 1)
        {
            if (playerPos.x <= 8.3f)
            {
                transform.position += Vector3.right * speed * Time.deltaTime;
            }
        }
    }
}
