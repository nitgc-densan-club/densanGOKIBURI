using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onion : MonoBehaviour
{
    public Rigidbody rby;
    // Start is called before the first frame update
    void Start()
    {
        rby = GetComponent<Rigidbody>();
        rby.AddForce(3.0f, 3.0f, 0, ForceMode.Impulse);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
