using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;


public class UpgradeMenu : MonoBehaviour
{

    public bool isSwitchedOn = false;
    public GameObject UpgradeMenuUI;
    // Start is called before the first frame update
 
    void Start()
    {
        Resume();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (isSwitchedOn)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        UpgradeMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isSwitchedOn = false;
    }

    public void Pause()
    {
        UpgradeMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isSwitchedOn = true;
    }

    
}
