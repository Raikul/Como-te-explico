﻿using UnityEngine;

public class MaskController : MonoBehaviour {

    public float size = 37;
    float fscale;
    Transform myTransform;
    Vector3 v3scale;
    Light fogLight;

    bool decays = false;
    private void Start()
    {
        //myTransform = GetComponent<Transform>();
        fogLight = GetComponentInChildren<Light>();
    }


    void Update()
    {
        /*fscale = size;

        v3scale = new Vector3(fscale, fscale, fscale);

        myTransform.localScale = v3scale;*/

        fogLight.spotAngle = size;

        if (decays)
            FogDecrease(2f);
    }

    void FogDecrease(float factor)
    {
        size -= Time.deltaTime * factor;
        fogLight.intensity -= Time.deltaTime * factor / 10;
    }
}
