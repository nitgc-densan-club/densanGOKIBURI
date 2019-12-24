using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Add : MonoBehaviour
{
    // Start is called before the first frame update
    
      float accel = 1.0f;
      Rigidbody rb ;
    Vector3 force = new Vector3(0.0f, 0.0f, 1.0f);

    float x;
    float z;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb = GetComponent<Rigidbody>();

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
            if (accel > -5.0f)
            {
                accel = accel - 0.3f;
            }
            rb.AddForce(force);
            transform.position += transform.forward * Time.deltaTime * accel;
        }
        if (Input.GetKey(KeyCode.W))
        {
            if (accel < 20.0f)
            {
                accel = accel + 0.3f;
            }
            rb.AddForce(force);
            transform.position += transform.forward * Time.deltaTime * accel;
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
        


    }
}

    
