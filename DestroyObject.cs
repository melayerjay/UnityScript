using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public GameObject particle;
    void Start(){
        StartCoroutine("destroy");
    }

    IEnumerator destroy(){
        yield return new WaitForSeconds(2);
        Instantiate(particle,transform.position,Quaternion.identity);
        Destroy(gameObject);
    }
            
}
