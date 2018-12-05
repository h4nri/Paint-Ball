using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovement : MonoBehaviour {

    private Rigidbody2D rb;
    [SerializeField] private float velocity;

    private void Start () {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(velocity, 0.0f);
	}
	
	private void Update () {
		
	}
}
