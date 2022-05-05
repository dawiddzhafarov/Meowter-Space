using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerInterface : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Health health;
    [SerializeField] private TextMeshProUGUI textHP;
    [SerializeField] private TextMeshProUGUI textEnemies;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hp = health.GetHealth();
        textHP.text = $"HP: {hp}";
        
    }
}
