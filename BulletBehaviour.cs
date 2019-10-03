using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    Rigidbody rg;
    // Start is called before the first frame update
    void Start()
    {   
        rg = this.GetComponent<Rigidbody>();
        rg.AddForce(Vector3.forward*50);
        StartCoroutine(DestroyByTime());
    }

    // Update is called once per frame
    void Update()
    {
        // this.transform.position += Vector3.forward;
        //rg.AddForce(Vector3.forward*50);   
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.transform.tag == "Boudary"){
            
            Destroy(this.gameObject);
        }
    }

    IEnumerator DestroyByTime(){
        yield return new WaitForSeconds(5f);
        Destroy(this.gameObject);
    }

}
