using UnityEngine;

public class PlayerMaskController : MonoBehaviour {

    public float size = 45;
    float fscale;
    Vector3 scale;
    Transform tr;
    Vector3 v3scale;

    public bool decays = true;


    void Update()
    {
        fscale = size;

        v3scale = new Vector3(fscale, fscale, fscale);
        tr = this.GetComponent<Transform>();
        scale = v3scale;

        tr.localScale = v3scale;

        if (decays)
            FogDecrease(1.3f);

    }

    void FogDecrease(float factor)
    {
        size -= Time.deltaTime * factor;
    }

    
}


