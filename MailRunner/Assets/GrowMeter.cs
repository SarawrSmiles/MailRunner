using UnityEngine;
using System.Collections;

public class GrowMeter : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.G)) {
			transform.localScale += new Vector3 (0, .001F, 0);
			transform.localPosition += new Vector3 (0.001F, 0, 0);
		}
	}
}
