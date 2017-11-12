using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnLVLStart : MonoBehaviour {

    public Transform target;
    public float speed = 5;
    private bool start;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.S))
        {
            start = !start;
        }
        if (start)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
    }
}
