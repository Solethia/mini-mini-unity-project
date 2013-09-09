using UnityEngine;

public class GUI_LauncherScript : MonoBehaviour {

	public float indicatorSpeed;
	private float boundaryRight = 0.995f; // Used for changing direction
	private float boundaryLeft = 0.005f; // Used for changing direction
	private bool direction = true; //true (right) false (left)
	
	void Start () {
	
	}
	
	void Update () {
		//Debug.Log(transform.localPosition);
		//Determine if a direction change is necessary
		if (transform.localPosition.x > boundaryRight){direction = false;}
		else if (transform.localPosition.x < boundaryLeft) {direction = true;}
		//Update position of the indicator
		Vector3 newPosition;
		if (direction) {newPosition = transform.localPosition + new Vector3(indicatorSpeed, 0, 0)*Time.deltaTime;}
		else {newPosition = transform.localPosition - new Vector3(indicatorSpeed, 0, 0)*Time.deltaTime;}
		//actually move the indicator
		transform.localPosition = newPosition;
	}
}
