using UnityEngine;
using System.Collections;

public class StartShooter : MonoBehaviour {
public float jump = 0.5f;
	public bool moveCamera = true;
	Vector3 kameraPosition;
	// Use this for initialization
	void Start () {
		
				target = kameraPosition = Camera.main.camera.transform.localPosition;
		Debug.Log(kameraPosition);
	}
	Vector3 target;
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown(KeyCode.A))
		{
			target = kameraPosition;
		}
		
		if (Input.GetKeyDown(KeyCode.Space)/* || Input.GetMouseButton(0)*/)
		{
				
				//Getting the cameras current position
				//Changing the cameras position to -20 z-axis
				//theCamera.transform.position = new Vector3(kameraPosition.x, kameraPosition.y, kameraPosition.z-20f);
				target = new Vector3(kameraPosition.x, kameraPosition.y, kameraPosition.z-20f);
				
				//Run this only once
			
			Vector3 position = transform.position;
			position.x += jump*Time.deltaTime;
			position.y += jump*Time.deltaTime;
			transform.position = position;
			/*rigidbody.AddForce(Vector3.up);
			rigidbody.AddForce(Vector3.right);*/
			Debug.Log("Input godkendt!");
		}
		Camera.main.transform.localPosition = Vector3.Lerp(Camera.main.transform.localPosition, target, Time.deltaTime*0.4f);
		
	}
	
	void OnCollisionEnter(Collision col)
	{
		Debug.Log("COLLISSSSISOOONN!!!");
	}
	
	public void MoveCameraWhenStart()
	{

	}
}
