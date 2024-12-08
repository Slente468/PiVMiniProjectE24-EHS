using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// this script is tracking the time. and what happens to it. It tracks the time it takes from getting from point a to b. 
//the Timer starts when the Player leaves StartZone. The Timer stops when one crosses into the collider of EndZone. 
/// <summary>
/// option make safezone a rock one can pick up and move. till point b.
/// </summary>
public class Highscore : MonoBehaviour
{
    //the text UI element address
    [SerializeField] TextMeshProUGUI timeCounterText;


    [SerializeField] int timeScore;


    // Start is called before the first frame update
    void Start()
    {

    }

    public void TimeCounter()
    {
        timeScore = (int)Time.time;
        timeCounterText.text = timeScore.ToString();
    }

    //might be able to use switch statement to get this OR else if statements
    public void StartZone()
    {
        // if collision on enter == true, then start counting timeScore. 
        //if (Collider.OnCollisionExit == true) 
        void OnTriggerEnter(Collider other)
        {
            //if () { }

        }
    }
    public void SafeZone()
    {
        // if collision on enter == true, then stop counting timeScore. 
    }

    public void EndZone()
    {
        // if collision on enter == true, then stop counting timeScore. + delay time + go to next scene. 
    }

    // Update is called once per frame
    void Update()
    {
        //this counts from starting to run the game. We need it to start when SampleScene is run.
        TimeCounter();
    }

    //Notice: if TimeCounter() does not seem to work go to Canvas Highscore and see if the TextMeshPro text element is but into the [SerializeField] TextMeshProUGUI timeCounterText field. 
}
