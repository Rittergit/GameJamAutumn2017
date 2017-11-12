using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour {

    public float speed = 5;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(-Vector3.forward * Time.deltaTime * speed);
        if (this.transform.position.z <= 0)
            this.transform.position = new Vector3(0, 0, 240);
    }
}
