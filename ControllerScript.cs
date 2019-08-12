using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerScript : MonoBehaviour
{   
    public GameObject Cube;
    float movementVertical,movementHorizontal;
    Vector3 MoveVector;
    void Start()
    {
        // temp = GameObject.Find("Cube");
        // MoveVector = new Vector3(0,0,0);
        StartCoroutine("sampleCoroutine1");

        PlayerPrefs.SetInt("ID",1);
        
    
    }

    
    // Update is called once per frame
    void Update()
    {
            // movementVertical = Input.GetAxis("Vertical");
            // movementHorizontal = Input.GetAxis("Horizontal");

            // MoveVector.x = movementHorizontal;
            // MoveVector.y = movementVertical;

            // this.transform.Translate(MoveVector);

            // if(Input.GetKeyDown(KeyCode.Z)){
            //     Instantiate(Cube,Vector3.zero,Quaternion.identity);
            // }

            // if(Input.GetButtonDown("MyInput")){
            //     Debug.Log("Space is pressed");
            // }

            // if(Input.GetKey(KeyCode.Space)) {
            //     Debug.Log("SpaceKey Is pressed;");
            // }

            // if(Input.GetKeyDown(KeyCode.E)){
            //     Debug.Log("E is pressed");
            // }
        
            // if(Input.GetMouseButton(0)){
            //     Debug.Log("mousePressed");
            // }

            //Vector3 mousePos = Input.mousePosition;
           Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,Camera.main.nearClipPlane + 10f));
            
            //Debug.Log(mousePos);
            if(Input.GetMouseButtonDown(0)){
                Instantiate(Cube,mousePos,Quaternion.identity);
            }

    }

    // IEnumerator sampleCoroutine() {
    //     yield return new WaitForSeconds(5);
    //     Debug.Log("Here...!!!");
    //     Debug.Log(PlayerPrefs.GetInt("ID"));
    //    // StartCoroutine("sampleCoroutine");
    // }

    IEnumerator sampleCoroutine1(){
        yield return new WaitForSeconds(3);
        Debug.Log("HERE!!!");
        StartCoroutine(sampleCoroutine1());
    }
}
