using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBlaster : MonoBehaviour
{
    public GameObject thing; // Object to instantiate
    public float force = 6.0f; // Impulse force to apply

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Create thing at same location and rotation as this object
            // Use transform.up to move instantiation point along local y axis
            GameObject g = Instantiate(thing, transform.position + transform.up, transform.rotation);

            // Get its Rigidbody and apply relative force
            Rigidbody2D rb = g.GetComponent<Rigidbody2D>();
            rb.AddRelativeForce(new Vector2(0, force), ForceMode2D.Impulse);
        }
    }
}
