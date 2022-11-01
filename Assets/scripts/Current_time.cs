using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Current_time : MonoBehaviour
{
    public TMP_Text TimeText;
    public string Time;
    public string testtime;
    public int testtime1 = 1650;
    // Start is called before the first frame update

       public string dateInput = "22:38";    //check this out 
   public DateTime parsedDate = DateTime.Parse("22:38");


    void Start()
    {
        testtime = testtime1.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        Time = System.DateTime.Now.ToString("HH:mm");
        print(testtime);
        TimeText.text = Time;
        print(Time);
        if (Time == testtime)
        {
            print("sleepytime");
        }

    }
}
