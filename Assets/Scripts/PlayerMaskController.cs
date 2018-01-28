using UnityEngine;

public class PlayerMaskController : MonoBehaviour {

    public float size = 45;
    float fscale;
    Vector3 scale;
    Transform myTransform;
    Vector3 v3scale;

    public bool decays = true;

    private void Start()
    {
        myTransform = GetComponent<Transform>();
    }


    void Update()
    {
        fscale = size;

        v3scale = new Vector3(fscale, fscale, fscale);

        myTransform.localScale = v3scale;

        if (decays)
            FogDecrease(1.3f);
    }

    void FogDecrease(float factor)
    {
        size -= Time.deltaTime * factor;
    }

    
}


