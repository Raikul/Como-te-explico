using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskController : MonoBehaviour {

    public float size = 45;
    float fscale;
    Vector3 scale;
    Transform tr;
    Vector3 v3scale;

    

    bool decays = false;



	
	// Update is called once per frame
	void Update () {
        fscale = size;

        v3scale = new Vector3(fscale, fscale, fscale);
        tr = this.GetComponent<Transform>();
        scale = v3scale;

        tr.localScale = v3scale;

        if (decays)
            FogDecrease(2);

    }

    void FogDecrease(int factor)
    {
        size -= Time.deltaTime * factor;
    }

    
}
