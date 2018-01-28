using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle : MonoBehaviour {
    PlayerMaskController playerLight;
    float value = 15;

    private void Start()
    {
        playerLight = Game.PlayerLight;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        playerLight.size += value;
        Destroy(this.gameObject);
    }
}
