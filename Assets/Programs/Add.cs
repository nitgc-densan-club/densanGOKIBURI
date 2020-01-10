using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Add : MonoBehaviour
{
    // Start is called before the first frame update
    
    float accel = 1.0f;
    Rigidbody rb ;
    Vector3 force = new Vector3(0.0f, 0.0f, 100.0f);

    float x;
    float z;

    private const float MaxSpeed = 100.0f;
    private const float MinSpeed = -800.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(force);
    }

    void FixedUpdate()
    {
        //rb = GetComponent<Rigidbody>();

        /*
        x = Input.GetAxis("Horizontal") * speed;
        z = Input.GetAxis("Vertical") * speed;
        rb.AddForce(x, 0, z);
        */
    }
    void Update() 
    {
        //rb.AddForce(force);
    }
}

/*
    {
        if (Input.anyKey)
        {
            if (Input.GetKey(KeyCode.S))
            {
                accel = accel - 10.0f;
            }
            if (Input.GetKey(KeyCode.W))
            {

                accel = accel + 20.6f;

                //rb.AddForce(force);
            }
            if (Input.GetKey(KeyCode.D) && accel < 23.0f)
            {
                transform.Rotate(0, 30 * Time.deltaTime, 0);
                //accel = accel * 0.01f;
            }
            if (Input.GetKey(KeyCode.A) && accel < 23.0f)
            {
                transform.Rotate(0, -30 * Time.deltaTime, 0);
                //accel = accel * 0.01f;
            }

            if (Input.GetKey(KeyCode.D) && accel > 23.0f)
            {
                transform.Rotate(0, 150 * Time.deltaTime, 0);
                //accel = -1.5f;
            }
            if (Input.GetKey(KeyCode.A) && accel > 23.0f)
            {
                transform.Rotate(0, -150 * Time.deltaTime, 0);
                //accel = -1.5f;
            }
        }
        else if ((Input.GetKeyUp(KeyCode.W)) || (Input.GetKeyUp(KeyCode.S)))
        {
            accel = 0;
            rb.velocity = Vector3.zero;
        }

       
        //accel = Mathf.Clamp(accel, MinSpeed, MaxSpeed);
        force = transform.forward * Time.deltaTime * accel;
        rb.AddForce(force, ForceMode.Impulse);

        accel = accel * 0.98f;

    }
    */
    
