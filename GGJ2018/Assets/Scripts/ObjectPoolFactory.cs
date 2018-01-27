using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolFactory : MonoBehaviour {

	public static ObjectPoolFactory factory;

	public GameObject obj;
	List<GameObject> pool = new List<GameObject>();

	public bool willGrow = true;

	public int poolSize = 1;

	void Awake(){
		factory = this;
	}

	void Start () {
		for (int i = 0; i < poolSize; i++) {
			GameObject o = Instantiate (obj) as GameObject;
			o.SetActive (false);
			pool.Add (o);
		}
	}

	public GameObject EnableObject(){
		for (int i = 0; i < poolSize; i++) {
			if (!pool [i].activeInHierarchy) {
				return pool [i];
				break;
			}
		}
		if (willGrow) {
			GameObject o = Instantiate (obj) as GameObject;
			pool.Add (o);
			return o;
		}
		return null;
	}

}
