using UnityEngine;
using System.Collections;

// This script applies a torque force to "spin" the object
public class Spin : MonoBehaviour
{

    Rigidbody2D rb;
    public float spinforce = 1.5f;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // If the left arrow is pressed apply positive torque (clockwise)
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddTorque(spinforce);
        }
        // If the right arrow is pressed apply negative force (conterclockwise)
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddTorque(-spinforce);
        }
    }
}
