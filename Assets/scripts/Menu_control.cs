using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class Menu_control : MonoBehaviour
{
    public TMP_InputField usernameInput;
    public static string username;

    void Start()
    {
        if (username != null)
          usernameInput.text = username;
    }


    public void SaveUsername(string newName)
    {
        username = newName;
        PlayerPrefs.SetString("saveNom", newName);
    }
}