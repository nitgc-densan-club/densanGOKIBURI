using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YMPlayer : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal") * speed;
        float z = Input.GetAxisRaw("Vertical") * speed;
        int number = 1;
        rb.AddForce(x, 0, z, ForceMode.Impulse);
        
        switch (number)
        {

            case 1: break;

            case 2: //onoinの加速効果
                    if (Input.GetKey(KeyCode.Q))
                    {
                        rb.AddForce(transform.forward * 30.0f, ForceMode.Force);
                    }
                   
                    break;





            }
    }
}
    