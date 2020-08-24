using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIVanish : MonoBehaviour
{
    public float appear;
    public float gone;
    public GameObject sprite;

    BoxCollider2D col;
    LOSS loss;
    Rigidbody2D rb;
    bool visible= true;

    void Start()
    {
        loss = GetComponent<LOSS>();
        col = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if(visible)
        {
            Invoke("Vanish", appear);
        }
        else
        {
            Invoke("Back", gone);
        }
    }

    void Vanish()
    {
        visible = false;
        loss.enabled = false;
        col.enabled = false;
        rb.gravityScale = 0;
        sprite.SetActive(false);
    }

    void Back()
    {
        visible = true;
        loss.enabled = true;
        col.enabled = true;
        rb.gravityScale = 1;
        sprite.SetActive(true);
    }
}
