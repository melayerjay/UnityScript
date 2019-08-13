using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCreation : MonoBehaviour
{
    GameObject createdObject;
    public Mesh myMesh;
    public Material myMaterial;
    Material blueMat;
    GameObject cube;
    GameObject[] arr;
    public List<GameObject> myList;
    // Start is called before the first frame update
    void Start()
    {
        myList = new List<GameObject>();
        blueMat = Resources.Load("BlueMat",typeof(Material)) as Material;
        createdObject = new GameObject("MyObject");
        createdObject.AddComponent<MeshFilter>();
        createdObject.AddComponent<MeshRenderer>();

        createdObject.GetComponent<MeshFilter>().mesh = myMesh;
        createdObject.GetComponent<MeshRenderer>().material = myMaterial;

       // cube = GameObject.Find("Cube");
       // cube = GameObject.FindGameObjectWithTag("myTag");
        arr = GameObject.FindGameObjectsWithTag("myTag");
        //cube.GetComponent<MeshRenderer>().material = myMaterial;

        foreach(GameObject temp in arr){
            myList.Add(temp);
        }
    
    }

    void Update()
    {
        // if(Input.GetMouseButtonDown(0)){
        //     cube.GetComponent<MeshRenderer>().material = myMaterial;
        // }

        // if(Input.GetMouseButtonUp(0)){
        //     cube.GetComponent<MeshRenderer>().material = blueMat;
        // }
        
        //GET KEY
        if(Input.GetKey(KeyCode.Space)){
            Debug.Log("Key Pressed");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Key Down");
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("Key Up");
        }

        if(Input.GetButton("MyButton")){
            Debug.Log("Button Pressed");
        }

        float axisValue = Input.GetAxis("Horizontal");
        Debug.Log(axisValue);
    }
}
