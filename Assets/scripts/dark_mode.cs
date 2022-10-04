using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class dark_mode : MonoBehaviour
{
    public bool IsDarkModeActive;

    public byte R = 71;

    public byte G = 113;

    public byte B = 108;

    public byte A = 255;


    public Image Backdrop;


    void OnSceneLoaded()
    {
        Backdrop = GameObject.FindGameObjectWithTag("Backdrop").GetComponent<Image>();
 
    }

    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }


    public void ChangeColor()
    {
        IsDarkModeActive = !IsDarkModeActive;
        if (IsDarkModeActive)
        {
            Backdrop.color = new Color32(71, 113, 108, 255);
            print("dark");
        }
        else
        {
            Backdrop.color = new Color32(123, 183, 176, 255);
            print("light");
        }
    }




}
