using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainScript : MonoBehaviour {

    private int previous;
	// Use this for initialization
	void Start () {
        previous = 0;
	}
	
	// Update is called once per frame
    void FixedUpdate () {
        transform.position -= transform.forward * Time.deltaTime * 4;

        if(this.transform.position.z <= -50){
            Instantiate(this, new Vector3(transform.position.x, transform.position.y, 74.3f), Quaternion.identity);
            Destroy(this.gameObject);
        }
	}



}

