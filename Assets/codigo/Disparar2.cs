
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar2 : MonoBehaviour {
    public Rigidbody bala;
    public Transform lanzador;
    public float velocidadDisparo;
    public float tiempoDisparo;
    public float iniciarDisparo;
    bool i = true;

    // Use this for initialization
    void Start () {
        if (i == true)
        {
            InvokeRepeating("Bolas", 0.0f, 6.0f);
        }
    }
	
	// Update is called once per frame
	void Update () {

        
    }
    void Bolas()
    {
        iniciarDisparo = Time.time + tiempoDisparo;
        Rigidbody instanciaBala;

        instanciaBala = Instantiate(bala, lanzador.position, Quaternion.identity);
        instanciaBala.AddForce(lanzador.forward * 100 * velocidadDisparo);
       
    }

}
