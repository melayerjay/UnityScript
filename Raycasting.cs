using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycasting : MonoBehaviour
{
    int layerMask = 2;


    RaycastHit hit;
    void Update()
    {
        //layerMask = ~layerMask;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin,ray.direction,Color.red);
        if(Physics.Raycast(ray.origin,ray.direction,out hit,50f)){
           
            Debug.Log("hitting!!");
           
            if(Input.GetMouseButtonDown(0)){
                Destroy(hit.collider.gameObject);
            }
            
        }else {
            Debug.Log("NOT HITTING!");
        }
    }
}
