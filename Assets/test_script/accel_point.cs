using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class accel_point : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 10, 30), ForceMode.VelocityChange);
    }
}
