using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{
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
               
        Debug.Log("weszło w colider");
        Debug.Log(col.collider.tag.Equals("Enemy"));
        
        
        if(col.collider.tag.Equals("Enemy")){
            Destroy(col.collider.gameObject);
            
        }
    }
}
