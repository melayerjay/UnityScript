using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeVector : MonoBehaviour
{
    public Transform target;
    public float speed;
    Vector3 dirVector;
    void Start()
    {
        dirVector = target.position - this.transform.position;
        Debug.Log(dirVector);
    }

    // Update is called once per frame
    void Update()
    {
      //this.transform.position = Vector3.MoveTowards(this.transform.position, target.position,speed * Time.deltaTime);

        //this.transform.position = Vector3.Lerp(this.transform.position, target.position,speed * Time.deltaTime);

       // this.transform.position = Vector3.Slerp(this.transform.position, target.position, speed * Time.deltaTime);

       // Debug.Log(Vector3.Distance(this.transform.position,target.position));

      // Debug.Log(Vector3.Normalize(dirVector));
    }
}
