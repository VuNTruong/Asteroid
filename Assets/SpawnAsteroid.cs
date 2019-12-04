using UnityEngine;
using System.Collections;

// This script spawns prefabs at the location and rotation of the object it is attached to
// at regular intervals
public class SpawnAsteroid : MonoBehaviour
{
    public float force = 3.0f; // Impulse force to apply

    // Thing to spawn
    public GameObject asteroid;

    // How many seconds between spawnings
    public float seconds = 5;

    float countdown; // How long to next spawning

    // Start the countdown
    void Start()
    {
        countdown = seconds;
    }

    // Update is called once per frame
    void Update()
    {

        // Time.DeltaTime is the amount of realtime that has passed since the last time
        // it was called. Decrement the countdown by that amount.
        countdown -= Time.deltaTime;

        // If the countdown has reached 0, reset it and spawn another thing.
        if (countdown <= 0)
        {
            countdown = seconds;

            // Generate random angles between -60 and 60
            float rotationRandom;

            rotationRandom = (float)UnityEngine.Random.Range(-60f, 60f);

            // Use the position and rotation of this object (its transform in 3D)
            GameObject g = Instantiate(asteroid, transform.position, Quaternion.Euler(0, 0, transform.rotation.z + rotationRandom));

            // Get its Rigidbody and apply relative force
            Rigidbody2D rb = g.GetComponent<Rigidbody2D>();
            rb.AddRelativeForce(new Vector2(0, force), ForceMode2D.Impulse);
        }
    }
}
