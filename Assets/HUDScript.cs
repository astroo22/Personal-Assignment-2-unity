using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HUDScript : MonoBehaviour
{
    public Text Score;
    private int score;
    public Text time;
    public float timeLeft = 120.0f;
    public bool stop = true;
    private float minutes;
    private float seconds;
    // Start is called before the first frame update
    void Start()
    {
        startTimer();
    }

    // Update is called once per frame
    void Update()
    {
        if (stop) return;
        timeLeft -= Time.deltaTime;

        minutes = Mathf.Floor(timeLeft / 60);
        seconds = timeLeft % 60;
        if (seconds > 59) seconds = 59;
        if (minutes < 0)
        {
            stop = true;
            minutes = 0;
            seconds = 0;
        }
        //        fraction = (timeLeft * 100) % 100;
    
    }
    public void IncrimentScore()
    {
        if(!stop)
        {
            Score.text = string.Format("Score {0}", ++score);
        } 
    }
    public void startTimer()
    {
        stop = false;
        timeLeft = 120;
        Update();
        StartCoroutine(updateCoroutine());
    }
    private IEnumerator updateCoroutine()
    {
        while (!stop)
        {
            time.text = string.Format("{0:0}:{1:00}", minutes, seconds);
            yield return new WaitForSeconds(0.2f);
        }
    }

}
