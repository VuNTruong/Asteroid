using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    // Explosion object that will be instantiated when the asteroid explode
    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        // Get the game object collided with
        GameObject gameObject = col.gameObject;

        if (gameObject.CompareTag("blaster"))
        {
            // Instantiate the explosion object
            Instantiate(explosion, transform.position, transform.rotation);

            // Destroy the game object itself
            GameObject.Destroy(this.gameObject);

            Debug.Log("Collided");
        }
    }
    
    void OnBecameInvisible ()
    {
        // Destroy the game object itself
        GameObject.Destroy(this.gameObject);
    }
}
