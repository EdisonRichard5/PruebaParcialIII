using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choque : MonoBehaviour {
    int punto = 0;
    int error = 0;
    public Text win;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        error = error + 1;
        print(error);
        if (error >= 3)
        {
            win.text = "PERDISTE";
            win.gameObject.SetActive(true);
        }
    }
    
}
