using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBehavior : MonoBehaviour {

	public Transform block;
	private List<Transform> blocks;

	void Start () {
		blocks = new List<Transform> ();

		blocks.Add (Instantiate (block, new Vector3(0, 0, 120), Quaternion.identity));
		blocks [0].Rotate (new Vector3 (0, 0, Random.Range (0, 5) * 60));
	}

	void FixedUpdate () {
		//blocks [0].transform.position -= new Vector3 (0, 0, 1);
		if (Input.GetKeyDown ("up")) {
			// Destroy GameObject
			if (blocks.Count > 0) {
				Destroy (blocks [0].gameObject);
				blocks.RemoveAt (0);
			}
		}
	}
}
