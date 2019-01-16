using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SphereScript : MonoBehaviour {
    private int position, altura;
    private bool jumping;
    private int previous;
    public GameObject enemy;
    // Use this for initialization
    void Start () {
        previous = 0;
        position = 1;
        altura = 1;
	}
	
	// Update is called once per frame
    void FixedUpdate () {
        previous++;
        if (previous >= 100)
        {
            addEnemy();
            previous = 0;
        }
    }

    public void salta()
    {
        transform.position += transform.up;
        jumping = true;
        Debug.Log("Salta");
    }

    public void izquierda()
   
    {
        if (position > 0)
        {
            transform.position -= transform.right;
            position--;
            Debug.Log("Izquierda");
        }
    }

    public void derecha(){
        if (position < 2)
        {
            transform.position += transform.right;
            position++;
            Debug.Log("Derecha");
        }
    }
   
    public void agacharse()
    {
        transform.position += transform.up;
        jumping = true;
        Debug.Log("Agacha");
    }

    void addEnemy()
    {
        float random = Random.Range(-2f, 2f);
        int iRandom = (int)random;
        Instantiate(enemy, new Vector3(this.transform.position.x + iRandom, this.transform.position.y + 1, this.transform.position.z + 20), Quaternion.identity);
    }

    void onCollisionEnter(){
        Destroy(this);
        Debug.Log("Objeto deberia ser destruido");
    }

}
