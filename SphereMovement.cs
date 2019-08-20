using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    Rigidbody rg;
    float horizontalMovement,VerticalMovement;
    public float force;
    public TextMesh Text;
    // Start is called before the first frame update
    void Start()
    {
        rg = this.GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        VerticalMovement = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalMovement,0f,VerticalMovement);

        this.transform.position += movement*Time.deltaTime*force;

        if(Input.GetKey(KeyCode.Space)){
            Text.text = "Changed";
        }
        // if(horizontalMovement > 0 || horizontalMovement < 0){
        //     rg.AddForce(Vector3.right * 25f * horizontalMovement);
        // }
        
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.collider.gameObject.tag == "myTag"){
            Debug.Log("Collision Happened");
            rg.AddForce(Vector3.left*force*10);
        }
    }
    
}
