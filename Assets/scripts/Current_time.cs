using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.Audio;

public class Current_time : MonoBehaviour
{
    public GameObject agendas;
    public GameObject stopalarm;
    public TMP_Dropdown dropdown;
    public TMP_Text TimeText;
    public string Time;
    public int currentHour;
    public int currentMinute;
    public int combinedTime;
    public string displaytime;
    public int dropdownTime;
    public AudioSource source;


    private void Start()
    {

        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        getTime();
        getClock();
    }

    void getTime()
    {

        displaytime = DateTime.Now.ToString("HH:mm");

        currentHour = DateTime.Now.Hour;

        currentMinute = DateTime.Now.Minute;

        combinedTime = Convert.ToInt32(currentHour.ToString() + currentMinute.ToString());

        TimeText.text = displaytime;
    }

    void getClock()
    {
        dropdownTime = Convert.ToInt32(dropdown.options[dropdown.value].text.Replace(":", ""));

        print(dropdownTime);
        print(combinedTime);

        if (dropdownTime == combinedTime)
        {
            source.Play();
            agendas.SetActive(false);
            stopalarm.SetActive(true);
        }
        else
            return;
    }

    public void StopMusic()
    {
        source.Stop();
        stopalarm.SetActive(false);
        agendas.SetActive(true);
    }

}
