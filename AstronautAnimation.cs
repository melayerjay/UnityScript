using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstronautAnimation : MonoBehaviour
{
    bool walk;
    Animator anim;
    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        
        if(move > 0 || move < 0){
            walk = true;
        }else{
            walk = false;
        }

        anim.SetBool("walk",walk);
    }
}
