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
        rby.AddForce()
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
