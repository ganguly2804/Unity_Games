using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;
	public float forwardForce = 1000f;
	public float sidewaysForce = 50f;

	// Update is called once per frame
	void FixedUpdate () {
		rb.AddForce(forwardForce*Time.deltaTime,0,0);

		if (Input.GetKey("d")) {
			rb.AddForce(0,0,-sidewaysForce*Time.deltaTime,ForceMode.VelocityChange);
		}
		if (Input.GetKey("a")) {
			rb.AddForce(0,0,sidewaysForce*Time.deltaTime,ForceMode.VelocityChange);
		}
		if (rb.position.y < 0.4f) {
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}
