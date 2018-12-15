using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    [SerializeField] private GameObject ball;

	private void Update () {
        transform.position = new Vector3(ball.transform.position.x + 10.0f, transform.position.y, transform.position.z);
	}
}
