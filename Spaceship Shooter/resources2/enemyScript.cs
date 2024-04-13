using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    // Public variable that contains the speed of the enemy
    public int speed = -5;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        Vector2 v = rb.velocity;
        v.x = 0;
        v.y = speed;
        rb.velocity = v;
        rb.angularVelocity = Random.Range(-200, 200);
        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //function called when the enemy collides with another object
    /* void OnTriggerEnter2D(Collider2D obj)
    {
        string name = obj.gameObject.name;

        // if collided with bullet
        if (name == "bullet_0(Clone)")
        {
            // Destroy itself (the enemy)
            Destroy(gameObject);

            // And destroy the bullet
            Destroy(obj.gameObject);
        }

        // if collided with the spaceship
        if (name == "spaceship_0")
        {
            // destroy itself (the enemy) to keep things simple
            Destroy(gameObject);
        }
    } */

}
