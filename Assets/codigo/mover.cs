using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mover : MonoBehaviour {

    // Use this for initialization
    public float moveSpeed = 25f;
    public float turnSpeed = 100f;
    public Text textoVictoria;
    public Text textoMonedas;
    int monedas = 0;
    bool movimiento = true;
    Vector3 posicionInicial;
    void Start () {
        posicionInicial = transform.position;
        textoVictoria.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (movimiento) { 
            if (Input.GetKey(KeyCode.UpArrow))
                transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

            if (Input.GetKey(KeyCode.DownArrow))
                transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);

            if (Input.GetKey(KeyCode.LeftArrow))
                transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);

            if (Input.GetKey(KeyCode.RightArrow))
                transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }
    }
    void OnTriggerEnter(Collider otro)
    {
        
        
        if (otro.CompareTag("Moneda"))
        {
            
            otro.gameObject.SetActive(false);
            monedas = monedas + 1;
            textoMonedas.text = "Lingote: " + monedas;
            Debug.Log("Moneda" + monedas);
            if (monedas == 2)
            {
                Debug.Log("has salido, felicidades");
                textoVictoria.enabled = true;
                monedas = 0;
                movimiento = false;
            }
        }



    }
}
