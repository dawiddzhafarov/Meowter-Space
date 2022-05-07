using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

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

    void Resume()
    {
        UpgradeMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isSwitchedOn = false;
    }

    void Pause()
    {
        UpgradeMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isSwitchedOn = true;
    }
}
