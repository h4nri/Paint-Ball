using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour {

    [SerializeField] private float lifetime; // TODO: Set lifetime based on x-velocity of ball 

    private void Start ()
    {
        Invoke("Die", lifetime);
    }
	
	private void Update ()
    {
		
	}

    private void Die()
    {
        Destroy(gameObject);
    }
}
