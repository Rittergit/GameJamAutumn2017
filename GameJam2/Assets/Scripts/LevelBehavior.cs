using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class LevelBehavior : MonoBehaviour {

	public Transform block;
	public int layersOverall = 5;
	public int minBlocksPerLayer = 1;
	public int maxBlocksPerLayer = 2;
	public int minSpeed = 1;
	public int maxSpeed = 5;
	public int minRangeBetweenBlocks = 10;
	public int maxRangeBetweenBlocks = 20;
	//TODO (dmartin): Add time after the level ends
	// public int finishTime = 60;

	private List<List<Transform>> layers;
	private float currSpeed;

	void Start () {
		layers = new List<List<Transform>> ();
		int lastRange = 0;
		currSpeed = minSpeed;

		for (var layerNr = 0; layerNr < layersOverall; ++layerNr) {
			var layer = new List<Transform> ();
			var blocksPerLayer = Random.Range (minBlocksPerLayer, maxBlocksPerLayer + 1);

			lastRange = Random.Range (minRangeBetweenBlocks, maxRangeBetweenBlocks) + lastRange;

			var existingblockRotations = new List<Vector3> ();
			for (var blockNr = 0; blockNr < blocksPerLayer; ++blockNr) {
				layer.Add (Instantiate (block, new Vector3 (0, 0, lastRange), Quaternion.identity));

				Vector3 rotation;
				do {
					rotation = new Vector3 (0, 0, Random.Range (0, 6) * 60);
				} while(existingblockRotations.Contains (rotation));

				layer[blockNr].Rotate (rotation);
			}

			layers.Add (layer);
		}
	}

	void FixedUpdate () {
		// Destroy oldObjects
		for (var layerNr = 0; layerNr < layers.Count; ++layerNr) {
			var removeLayer = false;
			foreach (var block in layers[layerNr]) {
				if (block.position.z < -1.3f) {
					Destroy (block.gameObject);
					removeLayer = true;
				}
			}

			if (removeLayer) {
				layers.Remove (layers [layerNr]);
			}
		}

		// Create new Objects
		if (layers.Count < layersOverall) {
			if (layers.Any()) {
				var lastLayer = layers.LastOrDefault ();

				if (lastLayer.Any()) {
					var firstBlock = lastLayer.FirstOrDefault ();
					var lastRange = Random.Range (minRangeBetweenBlocks, maxRangeBetweenBlocks) + firstBlock.position.z;
					var layer = new List<Transform> ();
					var blocksPerLayer = Random.Range (minBlocksPerLayer, maxBlocksPerLayer + 1);

					var existingblockRotations = new List<Vector3> ();
					for (var blockNr = 0; blockNr < blocksPerLayer; ++blockNr) {
						layer.Add (Instantiate (block, new Vector3 (0, 0, lastRange), Quaternion.identity));

						Vector3 rotation;
						do {
							rotation = new Vector3 (0, 0, Random.Range (0, 6) * 60);
						} while(existingblockRotations.Contains (rotation));

						layer[blockNr].Rotate (rotation);
					}

					layers.Add (layer);
				}
			}
		}

		foreach (var layer in layers) {
			foreach (var block in layer) {
				//block.transform.position -= new Vector3 (0, 0, currSpeed / 10);
				//block.GetComponent<Rigidbody>().MovePosition(block.GetComponent<Rigidbody>().position + new Vector3(0, 0, -(currSpeed/10)));
				block.transform.Translate(new Vector3(0, 0, -(currSpeed / 10)));
			}
		}
	}
}
