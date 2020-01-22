using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choque : MonoBehaviour {
    int punto = 0;
    int error = 0;
    public Text Buenas;
    public Text Malas;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnTriggerEnter(Collider otro)
    {
        if (otro.CompareTag("Buenas"))
        {
            otro.gameObject.SetActive(false);
            punto = punto + 1;
            Buenas.text = "Buenas: " + punto;
        }
        if (otro.CompareTag("Malas"))
        {
            otro.gameObject.SetActive(false);
            error = error + 1;
            Malas.text = "Malas: " + error;
        }

        

    }
    
}
