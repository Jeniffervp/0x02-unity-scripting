﻿using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 500f;

    public Rigidbody rigb;

    // Update is called once per frame
    public void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.UpArrow))
            rigb.AddForce(0, 0, speed * Time.deltaTime);
        if(Input.GetKey(KeyCode.RightArrow))
            rigb.AddForce(speed* Time.deltaTime, 0, 0);
        if(Input.GetKey(KeyCode.LeftArrow))
            rigb.AddForce((-1 * speed) * Time.deltaTime, 0, 0);
        if(Input.GetKey(KeyCode.DownArrow))
            rigb.AddForce(0, 0, (-1 * speed) * Time.deltaTime);
    }
}
