using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whirlpool : MonoBehaviour {

    MaskController light;
    bool whirpooled;

    float value = 15;

    // Use this for initialization
    void Start () {

        whirpooled = false;
	}
	


    void Update()
    {
        light = GameObject.FindWithTag("PlayerMask").GetComponent<MaskController>();
        
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (!Input.GetKeyDown(KeyCode.UpArrow))
        {
            //light.size += value;
            whirpooled = true;
            //Destroy(this.gameObject);
        }
        else { whirpooled = false; }

        if (whirpooled)
        {
            light.size -= 1 * Time.deltaTime;

        }
    }
}
