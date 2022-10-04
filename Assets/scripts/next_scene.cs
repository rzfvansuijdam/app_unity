using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class next_scene : MonoBehaviour
{
    [SerializeField] private string nextScene;

    public void ChangeScene()
    {
        SceneManager.LoadScene(nextScene);
    }

}
