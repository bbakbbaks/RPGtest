using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAction : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.up * Time.smoothDeltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.right * Time.smoothDeltaTime);
            
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.left * Time.smoothDeltaTime);
            
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.down * Time.smoothDeltaTime);
            
        }
    }
}
