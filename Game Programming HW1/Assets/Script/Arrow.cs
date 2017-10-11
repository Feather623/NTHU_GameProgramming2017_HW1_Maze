using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour {


	public Vector3 flyingSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.gameObject.transform.position += flyingSpeed;
	}

	private void OnCollisionEnter(Collision collision)
	{
		Destroy(this.gameObject);
	}
}
