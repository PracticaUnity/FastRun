using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Plane script added to: " + gameObject.name);
    }
	
	// Update is called once per frame
    void Update () {
        transform.Rotate(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"), 0.0f);
    }
}
