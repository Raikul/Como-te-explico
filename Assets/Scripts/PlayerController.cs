using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


    Rigidbody2D rb2D;
    public float speed;
    Vector2 v2;
    Vector2 movement;
    float rotation;
    public float rotationSpeed;
    Transform cam;

    PlayerMaskController plMsk;

	void Start () {

        rb2D = GetComponent<Rigidbody2D>();
        cam = GameObject.FindWithTag("MainCamera").GetComponent<Transform>();
        plMsk = GameObject.FindWithTag("PlayerMask").GetComponent<PlayerMaskController>();

    }
	
	
	void FixedUpdate () {

        Move();
    }

    private void LateUpdate()
    {
        cam.transform.position = this.transform.position - new Vector3(0,0,30);
    }



    void Move()
    {
        v2 = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        movement = new Vector2(0, v2.y);

        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        rotation *= Time.deltaTime;


        //rb2D.velocity = (movement * speed * 3);
        //rb2D.velocity = (Vector2.one);
        rb2D.AddRelativeForce(movement * speed * 10);
        this.transform.Rotate(0,0, - rotation * rotationSpeed * 10);
        //rb2D.AddTorque(-1 * rotationSpeed * rotation * 10);




    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Beacon"))
            plMsk.decays = false;

        Debug.Log("You're on a beacon");
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Beacon"))
            plMsk.decays = true;
    }


}
