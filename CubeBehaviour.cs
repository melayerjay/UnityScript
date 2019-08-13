using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{

    float horizontalMovement,VerticalMovement;
    Rigidbody rg;
    // Start is called before the first frame update
    void Start()
    {
        //this.gameObject.SetActive(false);
        rg = this.GetComponentInChildren<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        VerticalMovement = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalMovement,VerticalMovement,0f);

        //this.transform.position += movement;

        // if(Input.GetKey(KeyCode.Space)){
        //     //Addforce
        //     rg.AddForce(Vector3.right * 20f);
        // }
        if(horizontalMovement > 0 || horizontalMovement < 0){
            rg.AddForce(Vector3.right * 200f * horizontalMovement);
        }
    }
}
