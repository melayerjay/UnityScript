using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour
{
    public GameObject Cube;
    public List<GameObject> list1;
    // Start is called before the first frame update
    void Start()
    {
        // for(int i=0;i<list1.Count;i++){
        //     list1[i].SetActive(false);
        // }

        foreach(GameObject temp in list1){
            temp.SetActive(false);
        }

        Cube = new GameObject("Created Cube");
    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetKeyDown(KeyCode.Space)){
        //     if(Cube.activeSelf == true){
        //         Cube.SetActive(false);
        //     }else{
        //         Cube.SetActive(true);
        //     }
        // }

        if(Input.GetKeyDown(KeyCode.Q)){
            //First element on.
            //Everything else off;
            foreach(GameObject temp in list1){
                temp.SetActive(false);
            }
            list1[0].SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.W)){
            //second element on.
            //Everything else off;
            foreach(GameObject temp in list1){
                temp.SetActive(false);
            }
            list1[1].SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.E)){
            //Third element on.
            //Everything else off;
            foreach(GameObject temp in list1){
                temp.SetActive(false);
            }
            list1[2].SetActive(true);
            
        }

    }
}
