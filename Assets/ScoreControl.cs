using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreControl : MonoBehaviour
{
    // Start is called before the first frame update
    public HUDScript hudCanvas;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void scoreIn()
    {
        hudCanvas.IncrimentScore();
    }
    
}
