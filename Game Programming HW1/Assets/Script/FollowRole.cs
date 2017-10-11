using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowRole : MonoBehaviour {


    GameObject target;

	// Use this for initialization
	void Start () {
        target = GameObject.Find("unitychan");
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = target.transform.position;
	}
}
