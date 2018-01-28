using UnityEngine;

public class Fog : MonoBehaviour {

    public bool following = false;
    float acceleration = 0.02f;
    
    float speed;
    public Transform target;
    float time = 0;
    GameObject player;
    
    //float size = 100;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
      target = player.transform;
        //transform.localScale = new Vector3(size, size, size);
    }

    private void Update()
    {

        // si estoy siguiendo
        //if (following == true)
        // busco al jugador
        //{

        if (following)

            {
            speed = acceleration * time;
            //direction = target.position - transform.position;
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed);
            

            transform.localScale = new Vector3(transform.localScale.x + 0.1f*Time.deltaTime , transform.localScale.y + 0.1f * Time.deltaTime, transform.localScale.z + 0.1f * Time.deltaTime);
            //size += 1 * Time.deltaTime;
        }
        //}
        // calculo orientacion
        // me muevo en esa direccion
        // aumento la velocidad
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(this.gameObject);
    }

    // al acercarse, el fantasma empieza a seguirte muy lento, pero empieza a acelerar
    // lo atravieso, se destruye
    // lo esquivo, se empieza a hacer mas grande y te achica la luz
}
