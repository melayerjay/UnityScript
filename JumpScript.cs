using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{   
    Rigidbody rb;

    public float Jumpforce;
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            rb.AddForce(Vector3.up*Jumpforce);
            //this.transform.Translate(Vector3.up*Jumpforce);
        }
    }
}
