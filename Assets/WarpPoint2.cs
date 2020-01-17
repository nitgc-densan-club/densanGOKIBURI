using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpPoint2: MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.position = new Vector3(6,0,20);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
