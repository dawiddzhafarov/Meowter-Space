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
    public GameObject HudUi;
    [SerializeField] private PowerUps MinorDamageUp;
    private static AttackUp attackScript;
    private static DamageUp damageScript;
    private static DashDistanceUp dashScript;
    private static SpeedUp speedScript;
 
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
        HudUi.SetActive(true);
        UpgradeMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isSwitchedOn = false;
    }

    public void Pause()
    {
        HudUi.SetActive(false);
        UpgradeMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isSwitchedOn = true;
    }

    
    public void onClick(TextMeshProUGUI textMeshProUGUI)
    {
        //String upgradeName = textMeshProUGUI.text;
        //MinorDamageUp.Apply();
        /*if (upgradeName.Equals(AttackUp.name))
        {
            attackScript.Apply();
        } else if (upgradeName.Equals(DamageUp.name))
        {
            damageScript.Apply();
        } else if (upgradeName.Equals(MajorDamageUp.name))
        {
            damageScript.Apply();
        } else if (upgradeName.Equals(MinorAttackUp.name))
        {
            attackScript.Apply();
        } else if (upgradeName.Equals(MinorDamageUp.name))
        {
            damageScript.Apply();
            MinorDamageUp.Apply();
        } */
    }
}
