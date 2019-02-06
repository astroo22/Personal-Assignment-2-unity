using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RMove : MonoBehaviour
{
    public float speed = 2.5f;
    private bool isup = false;
    private float nextActionTime = 0.0f;
    public float period = 3.0f;
    private bool moveUP = false;
    private bool moveDOWN = false;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 Vict = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(moveUP)
        {
            moveup();
        }
        if(moveDOWN)
        {
            movedown();
        }
        if (Time.time > nextActionTime)
        {
            nextActionTime += period;
            
            if (!isup)
            {
                moveUP = true;
                moveDOWN = false;
            }
            else
            {
                moveUP = false;
                moveDOWN = true;
            }
        }
    }
    public void moveup()
    {
        Debug.Log("Move up");
        if (transform.position.y < -3.56)
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        else
        {
            isup = true;
        }
    }
    public void movedown()
    {
        if (transform.position.y > -4.30)
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
        else
        {
            isup = false;
            transform.position = new Vector3(Random.Range(-7.0f,7.0F), -4.11f,0);
        }
        
    }
}
