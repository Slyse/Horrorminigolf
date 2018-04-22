﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float speed = 4f;
    public float rotationSpeed = 100f;

    Rigidbody rb;
    public float sensitivity;
    public string HorizontalAim;
    public Vector3 axis;
    public Transform player;
    public Transform beam;


    void Update() {
        //float translation = Input.GetAxis("Vertical") * speed;
        //float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        //translation *= Time.deltaTime;
        //rotation *= Time.deltaTime;
        //transform.Rotate(0, rotation, 0);
        //transform.Translate(0, 0, translation);

        transform.Rotate(axis, Input.GetAxis(HorizontalAim) * sensitivity, 0);

        if (Input.GetKeyUp(KeyCode.Mouse0)) {
            rb = GetComponent<Rigidbody>();
            //rb.constraints = RigidbodyConstraints.FreezeRotationX;
            //rb.constraints = RigidbodyConstraints.FreezeRotationZ;
            rb.velocity = (beam.position - rb.position).normalized * 10f;
        }
        //rb:n avulla liikutta, ei transformilla
    }
}
