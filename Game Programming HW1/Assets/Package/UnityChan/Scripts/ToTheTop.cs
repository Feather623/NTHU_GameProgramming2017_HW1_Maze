using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToTheTop : MonoBehaviour {

    GameObject role;

	// Use this for initialization
	void Start () {
        role = GameObject.Find("unitychan");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Role"){
			GameManager.instance.GameFinish = true;
			role.transform.position = new Vector3(-0.7323371f, 20.25872f, 1.942007f);
		}
    }

}
