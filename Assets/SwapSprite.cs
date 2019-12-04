using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapSprite : MonoBehaviour
{

    public Sprite sprite1;
    public Sprite sprite2;
    SpriteRenderer sp;

    // Start is called before the first frame update
    void Start()
    {
        sp = GetComponent<SpriteRenderer>();

        sp.sprite = sprite1;
    }

    // Update is called once per frame
    void Update()
    {
        sp.sprite = sprite1;

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            sp.sprite = sprite2;
        }
    }
}
