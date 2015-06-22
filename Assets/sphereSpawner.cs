using UnityEngine;
using System.Collections;

public class sphereSpawner : MonoBehaviour {
	public GameObject spherePrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Instantiate (spherePrefab);
	}
}
