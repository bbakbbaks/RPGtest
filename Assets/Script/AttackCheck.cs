using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCheck : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log(collision.collider.tag);
    //}

    //void OnTriggerEnter(Collider other)
    //{
    //    if(other.gameObject.CompareTag("Enemy"))
    //    {
    //        Debug.Log("1");
    //    }       
    //}

    //private void OnCollisionStay(Collision collision)
    //{
    //    if(collision.gameObject.CompareTag("Enemy"))
    //    {
    //        Debug.Log("1");
    //    }
    //}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("1");
        }
    }
}
