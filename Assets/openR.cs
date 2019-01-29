using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openR : MonoBehaviour
{
    bool open = false;
    public GameObject rock;
    // Start is called before the first frame update
    void Start()
    {
        //Vector3 playerPos = transform.position;
        //Instantiate(rock, playerPos, Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = transform.position;
        if (Input.GetKeyDown(KeyCode.Space) && !open)
        {
            transform.Rotate(Vector3.forward * 90);
            open = true;
            Instantiate(rock, playerPos, Quaternion.identity);
        }
        else if (Input.GetKeyDown(KeyCode.Space) && open == true)
        {
            transform.Rotate(Vector3.forward * -90);
            open = false;
            
           // transform.parent = this;
        }
    }
}
