using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerOfScenesEntry : MonoBehaviour
{
    //This script holds the methods for the Startscreen and menues.  
    // holds:
    // - Start menu, 
    // - reset/ on esc, leads to settings
    // - settings menu

    AudioSource ThisAudioSource;


    //for method TurtorialMusic, to confirm whether turtorial scene or QuestSlide scene has started, used in musicScript. 
    public bool isTorstarted = false;

    public bool isStartstarted = false;

    public void StartMenu()
    {
        SceneManager.LoadScene("StartMenu");
        //Notice; to get access to the SceneManager class one must add using UnityEngine.SceneManagement; to the script.
        isStartstarted = true;
    }

    public void RunGame()
    {
        //put currently to 
        SceneManager.LoadScene("QuestSlide");
        //this.ThisAudioSource.Play();

    }

   




    public void QuestSlide()
    {
        SceneManager.LoadScene("Environment");
        
       
    }



    public void QuitGame()
    {
        Application.Quit();
    }

    

    //actually tutorial page
    public void Settings()
    {
        SceneManager.LoadScene("Settings");
        isTorstarted = true;
}

    public void ResetGame()
    {
        //This method is put in update, it does: when player press Esc then the method pauseMenu will be loaded. up.
        //scene is not made. 
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Settings();
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        ResetGame();
    }
}

//How to set up, -Find gameObject canvas give it this script,
//then -Find gameObject button, -> go to inspector -> On click event, add a new one, -> add the canvas in question,
//to the On Click event, -> on the function tab go down to button -> name of script, -> specific method for the button, that it should use.
//
// for PauseGame() method to work the scene needs a GameObject holding the script. 