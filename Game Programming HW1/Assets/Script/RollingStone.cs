using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingStone : MonoBehaviour {
	float Timer_f;
	int Timer_i;
	public Vector3 Rollforce;

	// Use this for initialization
	void Start () {
		Timer_f = 1f;
		Timer_i = 0;
	}
	
	// Update is called once per frame
	void Update () {
		Timer_f += Time.deltaTime;
		Timer_i = (int)Timer_f;
		if (Timer_i % 2 == 0) {
			transform.position += Rollforce;
		} else {
			transform.position -= Rollforce;
		}
	}
}
