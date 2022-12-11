using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class spawntest : MonoBehaviour
{
    public Button start;
    public GameObject captain;

    // Update is called once per frame
    void Update()
    {

    }

    public void placeobject()
    {
        Instantiate(captain, new Vector3(0, 10, 20), Quaternion.identity);
    }

        
}
