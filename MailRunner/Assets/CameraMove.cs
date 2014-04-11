using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W)) {
			transform.localPosition += new Vector3(0, 0, 0.1F);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.localPosition += new Vector3(0, 0, -0.1F);
		}
	}
}
