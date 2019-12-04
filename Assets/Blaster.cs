using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blaster : MonoBehaviour
{
    Text score;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        GameObject gameObject = col.gameObject;

        if (gameObject.CompareTag("asteroid"))
        {
            GameObject.Destroy(this.gameObject);
        }
    }
}
