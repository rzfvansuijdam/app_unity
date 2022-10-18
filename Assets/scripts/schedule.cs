/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class schedule : MonoBehaviour
{
    public TMP_InputField[] Agenda__part;

    public static string agenda_part;

    void Start()
    {
        if (agenda_part != null)
            Agenda__part[0].text = agenda_part;
    }




    public void SaveUsername(string schedule)
    {
        agenda_part = schedule;
        PlayerPrefs.SetString("saveNom", schedule);

        for (int i = 0; i < agenda_part.Length; i++)
        {
            agenda_part[i].ToString = PlayerPrefs.GetString("Savenom");
            //  username.text = PlayerPrefs.GetString("saveNom");
            //  NextButtons[i].SetActive(i <= which);
        }


    }
}
*/