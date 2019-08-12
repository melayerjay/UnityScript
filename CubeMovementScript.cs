using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovementScript : MonoBehaviour
{
    public GameObject BlueCube;
    Vector3 first,second;
    Vector3 result;
    Quaternion rot;
    void Start()
    {
    

        // first = this.transform.position;
        // second = BlueCube.transform.position;

        // result = second - first;

        // Debug.Log("First : "+first);
        // Debug.Log("Second : "+second);
        // Debug.Log("REsult : " +result);

        // Debug.Log(Vector3.Distance(first,second));

        this.transform.rotation = Quaternion.Euler(0,45,0);
        

        

    }

    void Update()
    {   
        // move with Uniform Speed
        // this.transform.position = Vector3.MoveTowards(this.transform.position,BlueCube.transform.position, 2f * Time.deltaTime);
                                    // Quaternion.RotateTowards

        //Move More naturally
        //this.transform.position = Vector3.Lerp(this.transform.position,BlueCube.transform.position, 2f * Time.deltaTime);
                                    //Quaternion.Lerp

        //this.transform.position = Vector3.Slerp(this.transform.position,BlueCube.transform.position, 2f * Time.deltaTime);
                                    // Quaternion.Slerp


        //this.transform.rotation = Quaternion.LookRotation(BlueCube.transform.position,Vector3.up);


        //BlueCube.transform.LookAt(this.transform);

        //this.transform.RotateAround(BlueCube.transform.position,Vector3.right,100f*Time.deltaTime);

        

        
    }
}
