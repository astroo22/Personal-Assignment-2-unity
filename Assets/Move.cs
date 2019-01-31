using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
   
        Vector3 playerPos = transform.position;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if(playerPos.x >= -4.20f )
            {
                transform.position += Vector3.left * speed * Time.deltaTime;
            }
           
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            if (playerPos.x <= 8.3f)
            {
                transform.position += Vector3.right * speed * Time.deltaTime;
            }
        }
    }
}
