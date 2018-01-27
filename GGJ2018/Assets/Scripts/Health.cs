using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

	public int currentHealth = 1000;
	public int maxHealth = 1000;
	public bool overShield = false;
	public bool immune = false;
	public bool dead = false;


	void Start () {}

	void Update () {
		if (currentHealth <= 0) {
			dead = true;
		}
		if (currentHealth > maxHealth) {
			currentHealth = maxHealth;
		}
	}

	public void DecreaseHealth(int amt){
		currentHealth -= amt;
	}

	public void IncreaseHealth(int amt){
		if (currentHealth < maxHealth) {
			currentHealth += amt;
		}
	}

}
