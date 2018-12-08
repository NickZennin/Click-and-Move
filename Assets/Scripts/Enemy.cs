using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	
	[SerializeField]
	private GameObject enemy;

	// Use this for initialization
	void Start () {
		enemy = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision otherObj) {
		if (otherObj.gameObject.tag == "Missile") {
			Destroy(gameObject,.5f);
		}
	}
}
