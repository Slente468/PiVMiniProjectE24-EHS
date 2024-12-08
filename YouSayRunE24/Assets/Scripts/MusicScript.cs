using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//this script includes the music that is played. 
public class MusicScript : MonoBehaviour


{
    public bool isTorstarted = false;
    public bool isStartstarted = false;

    AudioSource ThisAudioSource;

    [SerializeField] AudioClip rainyweather;//waterSyntz
    [SerializeField] AudioClip peacefulMorning; //peacefulMorning soundclip. 
    [SerializeField] AudioClip E24; //E24  
    [SerializeField] AudioClip TutorialOne; //AppEelRote

    //array for the music 
    [SerializeField] AudioClip[] Musiclist = new AudioClip[4];

    // Start is called before the first frame update
    void Start()
    {
        ThisAudioSource = GetComponent<AudioSource>();
        
        //assigning varibles to list
        Musiclist[0] = rainyweather;
        Musiclist[1] = peacefulMorning;
        Musiclist[2] = E24;
        Musiclist[3] = TutorialOne;

        
    }

    

    //should play a random track from the Musiclist when pressing v
    public void PlayMusiclist()
    {
        if (ThisAudioSource != null && Musiclist.Length > 0)
        {
            // Pick a random index
            int randomIndex = Random.Range(0, Musiclist.Length);

            // Play the selected clip
            ThisAudioSource.clip = Musiclist[randomIndex];
            ThisAudioSource.loop = true;
            ThisAudioSource.Play();
        }
        else
        {
            Debug.Log("Musiclist not working");
        }
    }

    public void SetListV()
    {
        if (Input.GetKeyDown(KeyCode.V)) 
        {
            PlayMusiclist();
        }
    }


    public void RainyWeather()
    {
        if (ThisAudioSource == null) 
        {
            //ThisAudioSource.Play();
        }
    }

    public void TutorialMusic()
    {
       if (isTorstarted == true && ThisAudioSource == null)
        {
            ThisAudioSource.clip = TutorialOne;
            ThisAudioSource.loop =true;
            ThisAudioSource.Play();
        }
    }

    public void StartMusic()
    {
        if (isStartstarted == true && ThisAudioSource == null)
        {
            ThisAudioSource.clip = TutorialOne;
            ThisAudioSource.loop = true;
            ThisAudioSource.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        SetListV();
    }
}
