using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    void FixedUpdate () {
        transform.position -= transform.forward * Time.deltaTime * 4;
	}
}
