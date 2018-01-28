using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InceptionController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        Application.OpenURL("http://romantic-ride-38b778.bitballoon.com/");
        Debug.Log("URLD");
    }
}
