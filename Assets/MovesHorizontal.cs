using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovesHorizontal : MonoBehaviour
{
    
    
    public Rigidbody2D rb;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity=new Vector3(
            -1* speed,
            rb.velocity.y,
            0        ) ;

        
    }
    
 
}
