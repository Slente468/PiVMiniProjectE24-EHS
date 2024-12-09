using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

// this script is tracking the time. and what happens to it. It tracks the time it takes from getting from point a to b. 
//the Timer starts when the Player leaves StartZone. The Timer stops when one crosses into the collider of EndZone. 
/// <summary>
/// option make safezone a rock one can pick up and move. till point b.
/// </summary>
public class Highscore : MonoBehaviour
{
    //the text UI element address
    [SerializeField] TextMeshProUGUI timeCounterText;

    public static int finalTimeScore;
    // Static variable to hold timeScore across scenes

    private bool isTimerRunning = false;
    private float startTime;

    [SerializeField] int timeScore;

    


    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        isTimerRunning = true;
    }

    public void TimeCounter()
    {
        if (isTimerRunning == true)
        {
            timeScore = (int)(Time.time - startTime);
            timeCounterText.text = timeScore.ToString();
        }
    }

    public void StopTimer()
    {
        isTimerRunning = false; // Freeze the timer
        finalTimeScore = timeScore; // Store the final score for the next scene
    }



    // Update is called once per frame
    void Update()
    {
        //this counts from starting to run the game. We need it to start when SampleScene is run.
        TimeCounter();

        //Notice: if TimeCounter() does not seem to work go to Canvas Highscore and see if the TextMeshPro text element is but into the [SerializeField] TextMeshProUGUI timeCounterText field. 
    }
}
