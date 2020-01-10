using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject Trap;
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
        rb.AddForce(x, 0, z, ForceMode.Impulse);

        if (Input.GetKeyDown(KeyCode.T))
        {
            Instantiate(Trap, new Vector3(transform.position.x, 3, transform.position.z), Trap.transform.rotation);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Trap")
        {

            Vector3 force = new Vector3(0.1f, 0.1f, 0.1f);    
            rb.AddForce(force);  
        }
    }
}
