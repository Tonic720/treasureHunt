using UnityEngine;
using System.Collections;

public class PlayerPhysicsMove : MonoBehaviour {

	public float moveSpeed;

	// Update is where rendering and input update
	// FixedUpdate is called once per physics frame
	void FixedUpdate () {
		// reset velocity every frame
		GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);

		// press W to apply upward force
		if ( Input.GetKey(KeyCode.UpArrow) ) {
			GetComponent<Rigidbody2D>().velocity += new Vector2(0f, moveSpeed) *Time.deltaTime;
		}

		if ( Input.GetKey(KeyCode.LeftArrow) ) {
			GetComponent<Rigidbody2D>().velocity += new Vector2(-moveSpeed, 0f) *Time.deltaTime;
		}

		if ( Input.GetKey(KeyCode.RightArrow) ) {
			GetComponent<Rigidbody2D>().velocity += new Vector2(moveSpeed, 0f) *Time.deltaTime;
		}

		if ( Input.GetKey(KeyCode.DownArrow) ) {
			GetComponent<Rigidbody2D>().velocity += new Vector2(0f, -moveSpeed) *Time.deltaTime;
		}

		if (transform.position.x <= -40f) {
			transform.position = new Vector2(-40f, transform.position.y);
		} else if (transform.position.x >= 40f) {
			transform.position = new Vector2(40f, transform.position.y);
		}

		// Y axis
		if (transform.position.y <= -40f) {
			transform.position = new Vector2(transform.position.x, -40f);
		} else if (transform.position.y >= 40f) {
			transform.position = new Vector2(transform.position.x, 40f);
		}

	}
}
