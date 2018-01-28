using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocks : MonoBehaviour {

    PlayerMaskController playerLight;
    float value = 5;

    AudioSource myAudio;
    BoxCollider2D myCollider;
    SpriteRenderer myRenderer;

    private void Start()
    {
        playerLight = Game.PlayerLight;
        myAudio = GetComponent<AudioSource>();
        myCollider = GetComponent<BoxCollider2D>();
        myRenderer = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        myAudio.Play();
        playerLight.size -= value;
        
        //Destroy(this.gameObject);
    }
}
