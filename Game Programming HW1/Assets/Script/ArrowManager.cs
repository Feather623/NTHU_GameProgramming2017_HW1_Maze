using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowManager : MonoBehaviour {

    public GameObject Arrow;
    float Timer_f;
    int Timer_i;
	// Use this for initialization
	void Start () {
        //Arrow = GameObject.Find("arrow");
		Generate_Arrow();

	}
	
	// Update is called once per frame
	void Update () {
        Timer_f += Time.deltaTime;
        Timer_i = (int)Timer_f;

        if(Timer_i == 5){
            Generate_Arrow();
            Timer_f = 0f;
        }
    }


    void Generate_Arrow(){
		Instantiate(Arrow, transform.position, transform.rotation);
    }
}
