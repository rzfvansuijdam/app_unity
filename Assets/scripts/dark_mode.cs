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
    public Button UIButton;
    public Button UIButton1;
    public Button UIButton2;
    public Button UIButton3;
    


    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void GetComponents()
    {

         Backdrop = GameObject.FindGameObjectWithTag("Backdrop").GetComponent<Image>();

         UIButton = GameObject.FindGameObjectWithTag("UIButton").GetComponent<Button>();

         UIButton1 = GameObject.FindGameObjectWithTag("UIButton1").GetComponent<Button>();

         UIButton2 = GameObject.FindGameObjectWithTag("UIButton2").GetComponent<Button>();

         UIButton3 = GameObject.FindGameObjectWithTag("UIButton3").GetComponent<Button>();

    }


    public void ChangeColor()
    {
        Backdrop.color = new Color32(71, 113, 108, 255);



        ColorBlock cb = UIButton.colors;
        cb.normalColor = new Color32(150, 150, 150, 255);
        UIButton.colors = cb;

        ColorBlock cb1 = UIButton1.colors;
        cb1.normalColor = new Color32(150, 150, 150, 255);
        UIButton1.colors = cb1;

        ColorBlock cb2 = UIButton2.colors;
        cb2.normalColor = new Color32(150, 150, 150, 255);
        UIButton2.colors = cb2;

        ColorBlock cb3 = UIButton3.colors;
        cb3.normalColor = new Color32(150, 150, 150, 255);
        UIButton3.colors = cb3;

    }

    public void Updatecolor()
    {
        IsDarkModeActive = true;
    }


    public void FixedUpdate()
    {
        if (IsDarkModeActive)
        {
            ChangeColor();
        }
        GetComponents();
    }




}
