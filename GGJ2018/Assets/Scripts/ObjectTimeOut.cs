using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTimeOut : MonoBehaviour {

	void OnEnable(){
		Invoke ("Disable", 2f);
	}

	void Disable(){
		gameObject.SetActive (false);
	}

	void OnDisable(){

	}
}
