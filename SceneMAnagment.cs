using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMAnagment : MonoBehaviour
{

    public Scene currentScene;
    AsyncOperation async;
    void Start()
    {   
        currentScene = SceneManager.GetActiveScene();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            async = SceneManager.LoadSceneAsync("New Scene");
            async.allowSceneActivation = false;
            Debug.Log(async.progress);
        }

        if(Input.GetKeyDown(KeyCode.Space)){
            // async.allowSceneActivation = true;
            // Debug.Log(async.progress);
            // if(async.isDone){
            //     SceneManager.LoadScene("New Scene");
            // }
        }
        
        // // SceneManager.LoadScene("New Scene");
        

        // // if(checkpoint cleared){
        // //     async = SceneManager.LoadSceneAsync("New Scene");
        // //     async.allowSceneActivation = false;
        // // }

    }
}
