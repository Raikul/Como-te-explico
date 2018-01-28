using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle : MonoBehaviour {
    MaskController light;

  
    float value = 15;
   

     
    
    // Use this for initialization
    void Start () {
        
        
    }
	
	// Update is called once per frame
	void Update () {
        light = GameObject.FindWithTag("PlayerMask").GetComponent<MaskController>();
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            light.size += value;
            //Destroy(this.gameObject);
                }
    }

    
}
