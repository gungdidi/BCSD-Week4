using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class MyBallB10 : MonoBehaviour
{
    Rigidbody rigid;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        rigid = GetComponent<Rigidbody>();
        //rigid.linearVelocity = new Vector3(2, 4, 3) 
        //rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);
    }

    private void FixedUpdate()
    {
        //rigid.velocity = Vector3.forward; //#1 속력 바꾸기

        if(Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 25, ForceMode.Impulse);
            Debug.Log(rigid.linearVelocity);
        }
    }

}
