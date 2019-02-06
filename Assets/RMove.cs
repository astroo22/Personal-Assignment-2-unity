using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RMove : MonoBehaviour
{
    public float speed = 1.5f;
    private bool isup = false;
    private float nextActionTime = 0.0f;
    public float period = 3.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        Vector3 Vict = transform.position;

        if (Time.time > nextActionTime)
        {
            nextActionTime += period;
            if(!isup)
            {
                while(transform.position.y != 0)
                {
                    transform.position += Vector3.up * speed * Time.deltaTime;
                }
                isup = true;
            }
            else
            {
                while (transform.position.y != -5)
                {
                    transform.position += Vector3.down * speed * Time.deltaTime;
                }
                isup = false;
            }
            

        }
        transform.position += Vector3.down * speed * Time.deltaTime;
    }
}
