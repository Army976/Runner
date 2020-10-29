using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    public Text BestScore;
    private int score, times;


    // Use this for initialization
    private float startTime;
    public GameObject ball;
    void Start()
    {
        startTime = Time.time;
        score = PlayerPrefs.GetInt("Player Score");
        Debug.Log(score);
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - startTime;
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f0");
        timerText.text = minutes + ":" + seconds;

        string minutes2 = ((int)score / 60).ToString();
        string seconds2 = (score % 60).ToString("f0");
        BestScore.text = "Best Score" + " : " + minutes2 + ":" + seconds2;

        if (ball.transform.position.y < -2)
        {
            times = (int)t;
            score = PlayerPrefs.GetInt("Player Score");
            //if (score == 0)
            //{
             //   score = 10000;
            //}
            if (score < times)
            {
                Debug.Log(times);
                PlayerPrefs.SetInt("Player Score", times);
            }


            Application.LoadLevel("runner");


        }
    }
}
