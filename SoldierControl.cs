using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierControl : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    public float speed;
    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            //this.transform.position += Vector3.forward * speed * Time.deltaTime;
            anim.SetBool("walk",true);
        }
        if(Input.GetKeyUp(KeyCode.W)){
            anim.SetBool("walk",false);
        }

        if(Input.GetKey(KeyCode.S)){
            //this.transform.position += Vector3.forward * speed * Time.deltaTime;
            anim.SetBool("walkB",true);
        }
        if(Input.GetKeyUp(KeyCode.S)){
            anim.SetBool("walkB",false);
        }


        if(Input.GetKeyDown(KeyCode.Space)){
            anim.SetBool("kick",true);
        }
        if(Input.GetKeyUp(KeyCode.Space)){
            anim.SetBool("kick",false);
        }
    }
}
