using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionTester : MonoBehaviour {


    GameObject collidedObject;
    Vector3 collidedObjectPosition;

    void OnCollisionEnter(Collision col) {
        collidedObject = col.gameObject;
        collidedObjectPosition = collidedObject.transform.position;
    }
    void OnTriggerEnter(Collider other)
    {
    }

    void setGravityToCollidedObject() {

    }
	// Use this for initialization
	void Start () {
		
	}

	
	// Update is called once per frame
	void Update () {
        //Debug.Log(collidedObject.normal);
	}
}
