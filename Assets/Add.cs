using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Add : MonoBehaviour
{
    // Start is called before the first frame update
    
      float accel = 5.0f;
      Rigidbody rb ;
    float x;
    float z;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        /*
        x = Input.GetAxis("Horizontal") * speed;
        z = Input.GetAxis("Vertical") * speed;
        rb.AddForce(x, 0, z);
        */
    }
    void Update()
    {

        if (Input.GetKey(KeyCode.S) )
        {
            if (accel > -0.7f)
            {
                accel = accel - 0.03f;
            }
        }
        if (Input.GetKey(KeyCode.W))
        {
            if (accel < 12.8f)
            {
                accel = accel + 0.3f;
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 80 * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -80 * Time.deltaTime, 0);
        }
        accel = accel * 0.98f;
        transform.position += transform.forward * Time.deltaTime * accel;


    }
}

    
