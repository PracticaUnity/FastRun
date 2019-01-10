using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void fixedUpdate()
    {
        transform.position -= transform.forward * Time.deltaTime * 4;

    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
    }

}
