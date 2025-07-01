using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    [SerializeField]
    private Rigidbody myRigidbody;
    //public Rigidbody myRigidbody;

    void Start()
    {
        // Rigidbody 컴포넌트를 가져오기
        //myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.AddForce(0, 500, 0);
    }
}
