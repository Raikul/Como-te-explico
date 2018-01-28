using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aggro : MonoBehaviour {

    Fog myParent;
    // Use this for initialization
    void Start () {
      myParent   = transform.parent.GetComponent<Fog>();
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        myParent.following = true;
        Debug.Log("AggroAggroAggro");
    }
}
