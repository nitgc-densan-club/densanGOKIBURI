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
        //プレイヤー移動
        float x = Input.GetAxisRaw("Horizontal") * speed;
        float z = Input.GetAxisRaw("Vertical") * speed;
        rb.AddForce(x, 0, z, ForceMode.Impulse);
        //トラップ(ホイホイ)生成
        if (Input.GetKeyDown(KeyCode.T))
        {
            Instantiate(Trap, new Vector3(transform.position.x, 3, transform.position.z), Trap.transform.rotation);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //トラップによる減速効果
        if (collision.gameObject.tag == "Trap")
        {
            speed = speed / 3;
            Debug.Log(speed);
            //スタートコルーチン
            StartCoroutine(EffectTimer(10.0f, "speed"));
        }
    }
    //コルーチンの本体
    IEnumerator EffectTimer(float time, string events)
    {
        yield return new WaitForSeconds(time);
        switch (events)
        {
            case "speed":
                speed = speed * 3;
                Debug.Log(speed);
                break;
        }
    }
}
