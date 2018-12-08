using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeathBar : MonoBehaviour {
	[SerializeField]
	private float health = 100;
	[SerializeField]
	private float maxHealth = 100;
	[SerializeField]
	private Image healthBarImage = null;
	// Use this for initialization
	void Start () {
		health = maxHealth;
	}
	[ContextMenu("Add")]
	public void AddHealth(float amount) {
		health += amount;
		if (health > maxHealth) {
			health = maxHealth;
		}else if(health < 0){
			health = 0;
		}
		updateHealthUI ();
	}

	private void updateHealthUI(){
		healthBarImage.fillAmount = (1 / maxHealth) * health;
	}
}
