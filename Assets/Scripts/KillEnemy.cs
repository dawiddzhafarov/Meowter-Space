using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{

    public AudioClip deathClip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D col)
    {


        if(col.collider.tag.Equals("Enemy")){
            Destroy(col.collider.gameObject);
        }
    }
}
