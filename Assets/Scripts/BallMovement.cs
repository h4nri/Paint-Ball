using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour {

    private Rigidbody2D rb;
    [SerializeField] private float acceleration;
    [SerializeField] private float initialVelocity;
    [SerializeField] private float velocity;
    private bool falling;

    private void Awake()
    {
        velocity = initialVelocity;
        falling = true;
    }

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0.0f, velocity);
	}
	
	private void FixedUpdate() {
        if (Input.GetMouseButton(0))
        {
            if (falling)
            {
                velocity = -initialVelocity;
            } else
            {
                velocity += acceleration;
            }

            falling = false;
        }
        else
        {
            if (falling)
            {
                velocity = velocity - acceleration;
            } else
            {
                velocity = initialVelocity;
            }

            falling = true;
        }

        rb.velocity = new Vector2(0.0f, velocity);
    }
}
