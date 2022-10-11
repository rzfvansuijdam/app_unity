using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GetCanvasObjects : MonoBehaviour
{

    public Image Backdrop;
    public Button UIButton;
    public Button UIButton1;
    public Button UIButton2;
    public Button UIButton3;


    // Start is called before the first frame update
    void Start()
    {
        GetComponents(); 
    }


    public void GetComponents()
    {

        Backdrop = GameObject.FindGameObjectWithTag("Backdrop").GetComponent<Image>();

        UIButton = GameObject.FindGameObjectWithTag("UIButton").GetComponent<Button>();

        UIButton1 = GameObject.FindGameObjectWithTag("UIButton1").GetComponent<Button>();

        UIButton2 = GameObject.FindGameObjectWithTag("UIButton2").GetComponent<Button>();

        UIButton3 = GameObject.FindGameObjectWithTag("UIButton3").GetComponent<Button>();

    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
