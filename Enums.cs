using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enums : MonoBehaviour
{
    public enum Side{
        left,
        right,
        middle
    }

    public Side currentSide = Side.middle;

    public Transform Lpos,Rpos;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // switch(currentSide){
        //     case Side.left:
        //        this.transform.position = Vector3.MoveTowards(this.transform.position,pos2.position,5f*Time.deltaTime);
        //         if(this.transform.position == pos2.position){
        //             currentSide = Side.right;
        //         }
        //     break;
            
        //     case Side.right:
        //         this.transform.position = Vector3.MoveTowards(this.transform.position,pos1.position,5f*Time.deltaTime);
        //         if(this.transform.position == pos1.position){
        //             currentSide = Side.left;
        //         }
        //     break;
        // }

        switch(currentSide){
            case Side.middle:
                if(Input.GetKeyDown(KeyCode.A)){
                    this.transform.position = Lpos.position;
                    currentSide = Side.left;
                }

                if(Input.GetKeyDown(KeyCode.D)){
                    this.transform.position = Rpos.position;
                    currentSide = Side.right;
                }
            
            break;
            case Side.right:
                if(Input.GetKeyDown(KeyCode.A)){
                    this.transform.position = Vector3.zero;
                    currentSide = Side.middle;
                }
            break;
            case Side.left:
                if(Input.GetKeyDown(KeyCode.D)){
                    this.transform.position = Vector3.zero;
                    currentSide = Side.middle;
                }
            break;
        }
    }
}
