﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            this.transform.position = this.transform.position + Vector3.forward; 
        }
        if(Input.GetKey(KeyCode.S)){
            this.transform.position = this.transform.position + Vector3.back;
        }
        if(Input.GetKey(KeyCode.A)){
            this.transform.position = this.transform.position + Vector3.left; 
        }
        if(Input.GetKey(KeyCode.D)){
            this.transform.position = this.transform.position + Vector3.right;
        }
    }
}
