using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PL : MonoBehaviour


{
    public Rigidbody2D PlayerRb;
    public float speed;

    void Start()
    {
        PlayerRb = GetComponent<Rigidbody2D>();
    }



    private void FixedUpdate()

    {
        PlayerRb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, 0f);
    }
}
