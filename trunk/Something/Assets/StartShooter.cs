using UnityEngine;
using System.Collections;

public class StartShooter : MonoBehaviour {
public float jump = 0.2f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0))
		{
			Vector3 position = transform.position;
			position.x += jump*Time.deltaTime;
			position.y += jump*Time.deltaTime;
			transform.position = position;
			/*rigidbody.AddForce(Vector3.up);
			rigidbody.AddForce(Vector3.right);*/
			Debug.Log("Input godkendt!");
		}
		
		
	}
	
	void OnCollisionEnter(Collision col)
	{
		Debug.Log("COLLISSSSISOOONN!!!");
	}
	
	
}
