using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public bool gameStart = false;
    public float timeMin;
    public float timeMax;
    private float timeLeft;
    public Text timerTxt;

    // Start is called before the first frame update
    void Start()
    {
        gameStart = true;
        timeLeft = Random.Range(timeMin, timeMax);
    }

    // Update is called once per frame
    void Update()
    {
        if(gameStart){
            if(timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
                updateTimer(timeLeft);
            }
            else
            {
                Debug.Log("Time Is UP!");
                timeLeft = 0;
                gameStart = false;
            }
        }
    }

    void updateTimer(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        timerTxt.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
