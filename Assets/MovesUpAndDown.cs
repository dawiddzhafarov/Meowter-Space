using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovesUpAndDown : MonoBehaviour
{
    private float upOrDown = 1;
    public float upBorder;
    public float downBorder;
    private float startingPosition;

    public Rigidbody2D rb;

    public float speed; 
    // Start is called before the first frame update
    void Start() {
        startingPosition = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        CheckMovementDirection();
        rb.velocity=(new Vector3(
            rb.velocity.x,
            upOrDown * speed,
            0        ) );
    }

    private void CheckMovementDirection()
    {
        if (transform.position.y-startingPosition > upBorder)
        {
            upOrDown = -1;
        }
        else if (transform.position.y-startingPosition < downBorder)
        {
            upOrDown = 1;
        }
    }
}
