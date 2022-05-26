using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class PowerUps : ScriptableObject {
    
    //protected GameObject player;
    //public GameObject player;

    private void OnEnable() {
        //player = GameObject.Find("Player");
    }
    

    public abstract void Apply();

}
