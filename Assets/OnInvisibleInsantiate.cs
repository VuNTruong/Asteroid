using UnityEngine;
using System.Collections;

// This script destroys an object when it leaves 
// the visible scene
public class OnInvisibleInsantiate : MonoBehaviour
{
    // Rigidbody2D component of the game object
    Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Event occus when this object is no  longer visible to
    // any camera
    void OnBecameInvisible()
    {

        // Destroy the gameObject component of object this 
        // script is attached to, removing it from game
        Debug.Log("Invisible");

        rb.position = new Vector2(0f, 0f);
    }
}
