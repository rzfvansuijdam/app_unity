using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class Rating : MonoBehaviour
{

    [SerializeField]
    public Button[] buttons;
    public TMP_Text text;
    public string[] strings;

    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        text.text = strings[0];
    }

    public void one()
    {
        strings[0] = strings[10];
    }    public void two()
    {
        strings[0] = strings[1];
    }    public void three()
    {
        strings[0] = strings[2];
    }    public void four()
    {
        strings[0] = strings[3];
    }    public void five()
    {
        strings[0] = strings[4];
    }    public void six()
    {
        strings[0] = strings[5];
    }    public void seven()
    {
        strings[0] = strings[6];
    }    public void eight()
    {
        strings[0] = strings[7];
    }    public void nine()
    {
        strings[0] = strings[8];
    }    public void ten()
    {
        strings[0] = strings[9];
    }

}
