using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    Quaternion rot;
    Quaternion finalrot;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
       // rot = Quaternion.Euler(new Vector3(45,0,0));
        // transform.rotation = rot;
       // finalrot = Quaternion.Euler(new Vector3(0,180,0));
    }

    // Update is called once per frame
    void Update()
    {
        // this.transform.rotation = Quaternion.RotateTowards(this.transform.rotation,finalrot,speed * Time.deltaTime);
        //this.transform.rotation = Quaternion.Lerp(this.transform.rotation,Quaternion.identity,speed * Time.deltaTime);

        float MouseX = Input.GetAxis("Mouse X");
        float MouseY = Input.GetAxis("Mouse Y");

        Vector3 temp = this.transform.localEulerAngles;
        temp.y += MouseX * 2;
        temp.x += MouseY *2;
        //this.transform.localEulerAngles = temp;

        //transform.Rotate(Vector3.up);
        //transform.RotateAround(Vector3.zero,Vector3.right,speed * Time.deltaTime);

        transform.Translate(Vector3.right * speed * Time.deltaTime);

        
    }
}
