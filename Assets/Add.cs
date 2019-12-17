using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Add : MonoBehaviour
{
    // Start is called before the first frame update
    
      float speed = 1.3f;
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
        x = Input.GetAxisRaw("Horizontal") * speed;
        z = Input.GetAxisRaw("Vertical") * speed;
        rb.AddForce(new Vector3(0, 0, z), ForceMode.Impulse);
    }
}

    
