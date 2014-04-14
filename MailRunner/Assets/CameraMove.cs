using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public float speed = 0.1F;
	public GameObject emeter;  


	
	// Update is called once per frame
	void Update () {
		emeter = GameObject.Find ("EnergyMeter");
		if (emeter.transform.localScale.y <= 0.001) {
						speed = 0.1F;
		} else {
			speed = emeter.transform.localScale.y * 3;
		}
		if (Input.GetKey(KeyCode.W)) {
			transform.localPosition += new Vector3(0, 0, 1F * speed);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.localPosition += new Vector3(0, 0, 1F * speed );
		}
	}
}
