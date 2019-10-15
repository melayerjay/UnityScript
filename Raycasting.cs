using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycasting : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    public GameObject prefab;
    
    [SerializeField]
    Transform cube;
    bool isSelected;
    GameObject selectedGameobject;

    // Start is called before the first frame update
    void Start()
    {
        //ray = new Ray(cube.position,Vector3.forward);

    }   

    // Update is called once per frame
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin,ray.direction,Color.red);
        
        if(Input.GetMouseButtonDown(0)){
            if(Physics.Raycast(ray,out hit,Mathf.Infinity)){
                Debug.Log("Target Hit Something");
                //Destroy(hit.collider.gameObject);
                selectedGameobject = hit.collider.gameObject;
                isSelected = true;
            }   
        }

        if(isSelected && selectedGameobject != null){
            selectedGameobject.transform.position = Camera.main.ScreenToWorldPoint(
                new Vector3(Input.mousePosition.x,Input.mousePosition.y,2f));
        }

        if(Input.GetMouseButtonUp(0)){
            isSelected = false;
            selectedGameobject = null;
        }
    }
}
