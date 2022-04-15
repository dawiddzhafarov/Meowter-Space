using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovesUpAndDown : MonoBehaviour
{
    private float upOrDown = 1;
    public float upBorder;
    public float downBorder;

    public Rigidbody2D rb;

    public float speed; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckMovementDirection();
        rb.velocity=(new Vector3(
            0,
            upOrDown,
            0        ) * speed);
    }

    private void CheckMovementDirection()
    {
        if (transform.position.y > upBorder)
        {
            upOrDown = -1;
        }
        else if (transform.position.y < downBorder)
        {
            upOrDown = 1;
        }
    }
}
