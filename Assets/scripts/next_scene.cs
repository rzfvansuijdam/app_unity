using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class next_scene : MonoBehaviour
{

    public GameObject main;
    public GameObject canvas1;

    [SerializeField] private string nextScene;


    public void ChangeScene()
    {
        SceneManager.LoadScene(nextScene);
    }

    public void ChangeCanvas()
    {
       canvas1.SetActive(true);
       main.SetActive(false);
    }

}
