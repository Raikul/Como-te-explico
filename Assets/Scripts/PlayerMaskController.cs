using UnityEngine;

public class PlayerMaskController : MonoBehaviour {

    public float size = 70;
    float fscale;
    Vector3 scale;
    Transform myTransform;
    Vector3 v3scale;
    Light fogLight;
    public bool decays = true;

    private void Start()
    {
        //myTransform = GetComponent<Transform>();
        fogLight = GetComponent<Light>();
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
        //fogLight.intensity -= (Time.deltaTime * factor / 100);
    }

    
}


