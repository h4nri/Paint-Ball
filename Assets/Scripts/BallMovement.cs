using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour {

    private Rigidbody2D rb;
    [SerializeField] private float acceleration;
    [SerializeField] private float currentYVelocity;
    [SerializeField] private float initialYVelocity;
    [SerializeField] private float xVelocity;
    private bool falling;

    private void Awake()
    {
        currentYVelocity = initialYVelocity;
        falling = true;
    }

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(xVelocity, currentYVelocity);
	}
	
	private void FixedUpdate() {
        if (Input.GetMouseButton(0))
        {
            if (falling)
            {
                currentYVelocity = -initialYVelocity;
            } else
            {
                currentYVelocity += acceleration;
            }

            falling = false;
        }
        else
        {
            if (falling)
            {
                currentYVelocity -= acceleration;
            } else
            {
                currentYVelocity = initialYVelocity;
            }

            falling = true;
        }

        rb.velocity = new Vector2(xVelocity, currentYVelocity);
    }
}
