using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

	// This is a reference to the Rigidbody component called "rb"
	public Rigidbody rb;
	//public Transform prefab;

	public float forwardForce = 2000f;  // Variable that determines the forward force
	public float sidewaysForce = 500f;  // Variable that determines the sideways force

	// We marked this as "Fixed"Update because we
	// are using it to mess with physics.
	void Update()
	{
		// Add a forward force
		rb.AddForce(forwardForce * Time.deltaTime, 0, 0);
		

		if (Input.GetKey("d"))  // If the player is pressing the "d" key
		{
			// Add a force to the right
			rb.AddForce(0, 0, -sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);
		}

		if (Input.GetKey("a"))  // If the player is pressing the "a" key
		{
			// Add a force to the left
			rb.AddForce(0, 0, sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);
		}

		/*if (Input.GetKeyDown(KeyCode.C))
		{
			prefab.GetComponent<BoxCollider>().enabled = false;

		}
		else if (Input.GetKeyUp(KeyCode.C))
		{
			prefab.GetComponent<BoxCollider>().enabled = true;
		}
		*/
	}
}
