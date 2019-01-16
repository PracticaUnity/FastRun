using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GameObject))]
public class GameManager : MonoBehaviour {
   
    public SphereScript esfera;

    public void salta(){
        esfera.salta();
    }
    public void izquierda()
    {
        esfera.izquierda();
    }
    public void derecha()
    {
        esfera.derecha();
    }
    public void agacharse()
    {
        esfera.agacharse();
    }
}
