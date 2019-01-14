using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SphereScript : MonoBehaviour {
    private int position, altura;
    private bool jumping;
	// Use this for initialization
	void Start () {
        position = 1;
        altura = 1;
	}
	
	// Update is called once per frame
    void FixedUpdate () {
        if (Input.GetKeyDown(KeyCode.RightArrow)&&position<2){
            transform.position += transform.right;
            position++;
        }else if(Input.GetKeyDown(KeyCode.LeftArrow)&&position>0){
            transform.position -= transform.right;
            position--;
        }else if(Input.GetKeyDown(KeyCode.UpArrow)){
            jump();
        }
    }

    private void jump(){
        transform.position += transform.up;
        jumping = true;
    }
    
	void onCollisionEnter(){
        Destroy(this);
        Debug.Log("Objeto deberia ser destruido");
    }
}
