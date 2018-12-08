using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Generator : MonoBehaviour {
	public GameObject enemy;
	[SerializeField]
	private GameObject piso;
	[SerializeField]
	private Text text;

	void Start() {
		piso = GameObject.FindGameObjectWithTag ("Floor");
		text = GameObject.FindObjectOfType<Text> ();
	}

	void Update(){
		text.text = "FPS: " + Time.renderedFrameCount;

		float x = Random.Range(-8f, 8f);
		float z = Random.Range(-2f, 2f);
		transform.position = new Vector3 (x, 0f, z);

		if (Time.frameCount % 50 == 0){
			enemy.transform.position = transform.position;
			Instantiate(enemy);
		}
	}
}