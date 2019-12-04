using UnityEngine;
using System.Collections;

// This script applies force along the local y-axis of the object
public class Forward : MonoBehaviour
{

    Rigidbody2D rb;
    public float force = 1;

    public GameObject explosion;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Apply force along the y-axis relative to the object itself
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddRelativeForce(new Vector2(0, force));
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        GameObject gameObject = col.gameObject;

        if (gameObject.CompareTag("asteroid"))
        {
            Instantiate(explosion, transform.position, transform.rotation);

            GameObject.Destroy(this.gameObject);
        }
    }
}
