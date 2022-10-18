using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Add_schedule : MonoBehaviour
{
    public GameObject[] NextButtons;

    public GameObject startButton;

    int which = 0;


    private void Start()
    {

    }


    public void GetNewAgenda()
    {
  
        for (int i = 0; i < NextButtons.Length; i++)
        {
           // only the one matching i == which will be on, all others will be off
            NextButtons[i].SetActive(i <= which);
        }

       


        which++;

        print(which);

        startButton.SetActive(false);

    }


}
