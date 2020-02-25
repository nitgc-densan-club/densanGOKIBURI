using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Jump : MonoBehaviour
{
    public GameObject Player;
    private Rigidbody PlayerRigid;//PlayerオブジェクトのRigidbobyを保管する
    public float Upspeed;　　　　//ジャンプのスピード
    // Use this for initialization
    void Start()
    {
        PlayerRigid = Player.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            

        {
            //上にジャンプする。
            PlayerRigid.AddForce(transform.up * Upspeed);


            
        }

    }
}
 