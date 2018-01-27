using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

	float dist = 0.0f;
	private int index ;
	private Transform target,target1;
	//private GameObject[] GMOArray;
	private GameObject GMO,GMO1;
	private float speed = 2f;
	//private Vector3 speedRot = Vector3.right * 50f;

	void Start () {
		index = 0;
		GMO = GameObject.Find ("Waypoint");
		GMO1 = GameObject.Find ("Waypoint (1)");
		//GMOArray [0] = GMO;
		//GMOArray[1] = GameObject.Find ("Waypoint(1)");
		target = GMO.transform;
		target1 = GMO1.transform;
	}

	void Update () {
		if ( index == 0) {
			transform.position = Vector3.MoveTowards (transform.position, target.position, speed * Time.deltaTime);
			if (dist < 3) {
				if (target) {
					dist = Vector3.Distance (target1.position, transform.position);
				}
				index = 1;
			} else {
				if (target1) {
					dist = Vector3.Distance (target.position, transform.position);
				}
			}
		} else {
			transform.position = Vector3.MoveTowards (transform.position, target1.position, speed * Time.deltaTime);
			if (dist < 3) {
				if (target) {
					dist = Vector3.Distance (target.position, transform.position);
				}
				index = 0;
			} else {
				if (target1) {
					dist = Vector3.Distance (target1.position, transform.position);
				}
			}
		}

	}
}
