using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class test_prefs : MonoBehaviour
{

    public TMP_Text username;

    // Update is called once per frame
    void Update()
    {


        username.text = PlayerPrefs.GetString("saveNom");
    }
}
