using UnityEngine;

public class MaskController : MonoBehaviour {

    public float size = 45;
    float fscale;
    Transform myTransform;
    Vector3 v3scale;

    bool decays = false;
    private void Start()
    {
        myTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update () {
        fscale = size;

        v3scale = new Vector3(fscale, fscale, fscale);

        myTransform.localScale = v3scale;

        if (decays)
            FogDecrease(2);
    }

    void FogDecrease(int factor)
    {
        if(size > 0)
            size -= Time.deltaTime * factor;
    }    
}
