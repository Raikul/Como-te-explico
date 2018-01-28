using UnityEngine;

public class Whirlpool : MonoBehaviour {

    PlayerMaskController light;
    bool whirpooled;

    float value = 15;

    // Use this for initialization
    void Start () {
        whirpooled = false;
        light = Game.PlayerLight;
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (!Input.GetKey(KeyCode.Space))
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
