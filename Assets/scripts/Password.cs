using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Password : MonoBehaviour
{
    [SerializeField] private string password;
    public TMP_InputField text;



    public void updatepassword()
    {
        password = text.text;
    }

    public void CheckPassword()
    {
        if (password == "password")
        {
            SceneManager.LoadScene("Homescreen");
        }
        else
        {
            print("error password incorrect");
        }

    }

}
