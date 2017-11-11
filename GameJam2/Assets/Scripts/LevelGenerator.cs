using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelGenerator : MonoBehaviour {

	public Transform block;
	private List<Transform> blocks;
	private List<Vector3> positionList;

	void Start () {
		blocks = new List<Transform> ();
		blocks.Clear ();
		positionList = new List<Vector3>{
			new Vector3(3.57f,2.11f,120.0f)
		};

		Instantiate (blocks [0], positionList [Random.Range (0, 0)], Quaternion.identity);
		//Instantiate (block, new Vector3 (i * 2.0F, 0, 0), Quaternion.identity);
	}

	void FixedUpdate () {
		if (Input.GetKey ("up")) {
			// Destroy GameObject
			// Move Position of Objects
			blocks[0].transform.position -=  new Vector3(0, 0, 1);
			Debug.Log ("Position: " + blocks[0].transform.position);
		}
	}
}