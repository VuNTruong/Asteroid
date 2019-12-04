using UnityEngine;
using System.Collections;

// Initial version of "throwing" script. 
// Assumes thing thrown has own script for motion (will do with forces later)
public class Falcon : MonoBehaviour
{

    // Prefab we will create
    public GameObject thing;

    public GameObject explosion;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // Throw if player presses space key
        if (Input.GetKeyDown(KeyCode.Space))
        {

            // Instantiate at position and rotation of player
            // Modified to start a bit to the left of player so does not appear inside player
            // (which could cause issues with collision)
            GameObject g = (GameObject)Instantiate(thing,
                                                    transform.position + new Vector3(-0.25f, 0, 0),
                                                    transform.rotation);

            // Destroy it after given amount of time
            GameObject.Destroy(g, 10);
        }

    }

    void OnCollisionEnter2D (Collision2D col)
    {
        GameObject gameObject = col.gameObject;

        if(gameObject.CompareTag("asteroid"))
        {
            Instantiate(explosion, transform.position, transform.rotation);

            GameObject.Destroy(this.gameObject);
        }
    }
}
