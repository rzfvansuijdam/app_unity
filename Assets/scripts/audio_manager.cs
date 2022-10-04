using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;


public class audio_manager : MonoBehaviour
{

    public Text ClipTitle;
    public Text currenttime;

    private int fullLength;
    private int playTime;
    private int seconds;
    private int minutes;

    public AudioClip[] musicClips;
    private int currentTrack;
    private AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();

      //  PlayMusic();

    }

    public void PlayMusic()
    {
        if (source.isPlaying)
        {
            return;
        }

        currentTrack--;
        if(currentTrack < 0)
        {
            currentTrack = musicClips.Length - 1;
        }
        StartCoroutine("WaitforMusicEnd");
    }


    IEnumerator WaitforMusicEnd()
    {
        while (source.isPlaying)
        {
            playTime = (int)source.time;
            ShowPlayTime();
            yield return null;
        }
        NextTitle();
            
     }

    public void NextTitle()
    {
        source.Stop();
        currentTrack++;
        if(currentTrack > musicClips.Length - 1)
        {
            currentTrack = 0;
        }
        source.clip = musicClips[currentTrack];
        source.Play();

        //showtitle
        ShowCurrentTitle();

        StartCoroutine("WaitforMusicEnd");
    }

    public void PreviousTitle()
    {
        source.Stop();
        currentTrack--;
        if (currentTrack > 0) 
        {
            currentTrack = musicClips.Length - 1;
        }
        source.clip = musicClips[currentTrack];
        source.Play();

        //showtitle
        ShowCurrentTitle();


        StartCoroutine("WaitforMusicEnd");
    }

    public void StopMusic()
    {
       
        source.Stop();
        StopCoroutine("WaitforMusicEnd");
    }

    void ShowCurrentTitle()
    {
        ClipTitle.text = source.clip.name;
        fullLength = (int)source.clip.length;
    }

    void ShowPlayTime()
    {
        seconds = playTime % 60;
        minutes = (playTime /60) % 60;
        currenttime.text = minutes + ":" + seconds.ToString("D2") + "/" + ((fullLength /60) % 60) + ":" + (fullLength % 60).ToString("D2");
    }

}
