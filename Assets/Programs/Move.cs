using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float MaxSpeed;//最高速を決める変数(km/h)
    public float MinSpeed;//再低速を決める変数(km/h*s)
    public float AccelPerSecond;//加速力を決める変数(km/h*s)
    public float BrakePerSecond;//ブレーキを決める変数(km/h*s)
    public float TurnPerSecond;//旋回力を決める変数(deg/s)
    private float speed;
    private Rigidbody rb;
    Vector3 force = new Vector3(0.0f, 0.0f, 0.0f);    // 力を設定

    void Start()
    {
        speed = 0;
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        //速さの計算
        if (Input.GetKey(KeyCode.W))
        {
            speed += AccelPerSecond * Time.deltaTime + 3;
            if (speed > MaxSpeed) speed = MaxSpeed;
        }
        /*else
        {
            speed -= AccelPerSecond * Time.deltaTime / 2;
            if (speed < 0) speed = 0;
        }*/

        else if(Input.GetKey(KeyCode.S))
        {
            speed += BrakePerSecond * Time.deltaTime - 3;
            if (speed < MinSpeed) speed = MinSpeed;
        } else
        {
            if (speed > 0)
            {
                speed -= AccelPerSecond * Time.deltaTime / 2;
                if (speed < 0) speed = 0;
            }else
            {
                speed -= BrakePerSecond * Time.deltaTime / 2;
                if (speed > -35) speed = 0;
            }
        }



        /*else
        {
            speed -= BrakePerSecond * Time.deltaTime / 2;
            if (speed > -35) speed = 0;
        }*/

        force = transform.forward * speed;    // 力を設定
        rb.AddForce(force, ForceMode.Force);            // 力を加える

             //rb.velocity = transform.forward * Speed;


        //旋回する角度の計算
        float Handle = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, TurnPerSecond * Handle * Time.deltaTime);

        if (Input.GetKeyUp(KeyCode.W) || (Input.GetKeyUp(KeyCode.S)))
        {
            speed = 0.0f;
            rb.velocity = Vector3.zero; // 3Dの場合)
            rb.angularVelocity = Vector3.zero;
        }    



    }
}
