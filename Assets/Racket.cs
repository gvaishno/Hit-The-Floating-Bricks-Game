using UnityEngine;
using System.Collections;

public class Racket : MonoBehaviour {
	
	public float paddleSpeed = 1f;
	
	private Vector2 playerPos = new Vector2 (0, -111f);
	
	void Update () 
	{
		float xPos = transform.position.x + (Input.GetAxis("Horizontal") * paddleSpeed);
		playerPos = new Vector3 (Mathf.Clamp (xPos, -81f, 87f), -111f);
		transform.position = playerPos;
		
	}
}