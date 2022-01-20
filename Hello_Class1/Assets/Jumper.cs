using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    public Rigidbody myRb;
    void Start()
    {
        myRb.AddForce(0, 500, 0);
    }

   
}
