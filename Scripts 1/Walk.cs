﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour {

	void Update(){
		if (Input.GetMouseButtonDown (0)) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

			if (Physics.Raycast (ray, out hit)) {
				if (hit.transform.name == "Capsule")
					transform.position = new Vector3 (-1, 0, 5);
			} 
		}
	} 

	// Use this for initialization
	//void Update () {
	//	transform.Translate(Time.deltaTime, 0, 0, Camera.main.transform);
	//}
	
	// Update is called once per frame
}
