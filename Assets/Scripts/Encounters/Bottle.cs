using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle : MonoBehaviour {
    PlayerMaskController playerLight;
    float value = 15;

    AudioSource myAudio;
    CircleCollider2D myCollider;
    SpriteRenderer myRenderer;

    private void Start()
    {
        playerLight = Game.PlayerLight;
        myAudio = GetComponent<AudioSource>();
        myCollider = GetComponent<CircleCollider2D>();
        myRenderer = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            myAudio.Play();
            playerLight.size += value;
            myCollider.enabled = false;
            myRenderer.enabled = false;
            Game.CollectFlower();
        }
    }
}
