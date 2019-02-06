using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RMove : MonoBehaviour
{
    public float speed = 10.5f;
    private bool isup = false;
    private float nextActionTime = 0.0f;
    public float period = 0.5f;

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
            
            if (!isup)
            {
                moveup();
              
            }
            else
            {
                movedown();
            }
        }
    }
    public void moveup()
    {
        Debug.Log("Move up");
        if (transform.position.y > -3.56')
        {
            for(int i =0; i<10;i++)
            {
                transform.position += Vector3.up * speed * Time.deltaTime;
            }
            Debug.Log("hit moveUP transform happened");
        }
        if(transform.position.y >=0)
        {
            isup = true;
        }
        
        
    }
    public void movedown()
    {
        Debug.Log("Move down");
        if (transform.position.y <= -3)
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
            Debug.Log("hit moveDown transform happened");
        }
        if (transform.position.y <=-5)
        {
            isup = true;
        }
        
    }
}
