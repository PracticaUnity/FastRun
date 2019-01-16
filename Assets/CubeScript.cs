using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void fixedUpdate()
    {
        transform.position -= transform.forward * Time.deltaTime * 4;
        if (this.transform.position.z < -60)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.GetComponent<TerrainScript>())
        {
            Destroy(collision.gameObject);
        }
    }
}


