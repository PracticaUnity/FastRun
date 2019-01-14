using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainScript : MonoBehaviour {

    public GameObject enemy;
    private int previous;
	// Use this for initialization
	void Start () {
        previous = 0;
	}
	
	// Update is called once per frame
    void FixedUpdate () {
        transform.position -= transform.forward * Time.deltaTime * 4;
        previous++;
        if (previous == 100)
        {
            addEnemy();
        }
	}

    void addEnemy(){
        previous = 0;
        float random = Random.Range(-2f, 2f);
        int iRandom = (int) random;
        Instantiate(enemy, new Vector3(this.transform.position.x+iRandom, this.transform.position.y+1, this.transform.position.z+10), Quaternion.identity);
    }
}

