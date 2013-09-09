using UnityEngine;
using System.Collections;

public class ColissionShooter : MonoBehaviour {
	Vector3 explosionPos;
	// Use this for initialization
	void Start () {
	explosionPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision collision) {
		Debug.Log("WE COLLIDED!!!!");
		
		collision.gameObject.rigidbody.AddForce(20f, 20f, 0f, ForceMode.Impulse);
		collision.gameObject.rigidbody.AddExplosionForce(10f, explosionPos, 5f, 3f);//(20f, 20f, 0f, ForceMode.Impulse);
		Debug.Log(explosionPos);
	}
}
