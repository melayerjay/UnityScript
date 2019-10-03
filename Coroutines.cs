using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutines : MonoBehaviour
{
    public GameObject cube;
    public int score = 0;

    [HideInInspector]
    public int Highscore = 0;

    [SerializeField]
    int temp;

    // Start is called before the first frame update
    void Start()
    {
       // StartCoroutine(DestoryCube());
       if(PlayerPrefs.HasKey("Highscore")){
           Highscore = PlayerPrefs.GetInt("Highscore");
       }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            score++;
            if(score >= Highscore){
                PlayerPrefs.SetInt("Highscore",score);
            }
        }
    }

    IEnumerator DestoryCube(){
        Debug.Log("Couroutine Start");
        yield return new WaitForSeconds(3f);
        Destroy(cube);

    }
}
