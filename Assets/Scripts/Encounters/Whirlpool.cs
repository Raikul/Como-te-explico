using UnityEngine;

public class Whirlpool : MonoBehaviour {

    PlayerMaskController playerLight;
    bool whirpooled;
    
    void Start () {
        whirpooled = false;
        playerLight = Game.PlayerLight;
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
            playerLight.size -= 3 * Time.deltaTime;
        }
    }
}
