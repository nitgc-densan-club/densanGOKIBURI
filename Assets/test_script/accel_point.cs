using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class accel_point : MonoBehaviour
{
    public float speedX; //ｙ方向の速度
    public float speedZ;// ｚ方向の速度
    public float minSpeed　= 1;//最小速度
    public float accel = 1; //加速度

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
        if(minSpeed <= speedX)//x方向の最低加速度
        {
            speedX = speedX - accel;
            other.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(speedX, 0, 0));//x方向に加速
        }
        if (minSpeed <= speedZ)
        {
            speedZ = speedZ - accel;
            other.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, speedZ));//z方向に加速
        }
        
    }
}
