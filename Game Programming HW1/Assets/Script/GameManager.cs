using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	public static GameManager instance;

	float timer_f=0f;
	int timer_i=0;
	public Text Clock;
	public bool startTiming = false;
	public bool GameFinish = false;

    GameObject Role;
    Vector3 initRot;
	public ThirdPersonCamera ThirdView;

	public static Flowchart DialogueChart;
	void Awake(){
		if (instance == null) {
			instance = this;
		}
	}

	// Use this for initialization
	void Start () {
		DialogueChart = GameObject.Find ("DialogueManager").GetComponent<Flowchart> ();
        Role = GameObject.Find("unitychan");
        initRot = Role.transform.eulerAngles;
    }

	public static bool isTalking{
		get { return DialogueChart.GetBooleanVariable ("對話中"); }
	}

	// Update is called once per frame
	void Update () {
		if (startTiming && !GameFinish) {
			timer_f += Time.deltaTime;
		} else if (!startTiming && !GameFinish) {
			timer_f = 0f;
		} else if (startTiming && GameFinish) {
			
		} else {
		}

		if (isTalking) {
			startTiming = false;
			ThirdView.enabled = false;
			Role.GetComponent<UnityChanControlScriptWithRgidBody> ().enabled = false;
		}
		else{
			ThirdView.enabled = true;
			Role.GetComponent<UnityChanControlScriptWithRgidBody> ().enabled = true;
			startTiming = true;
		}

		Clock.text = ""+Mathf.Round(timer_f * 100f) / 100f;

        if(Input.GetKeyDown(KeyCode.R)){
            Restart();
        }
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit();
		}
	}

    public void Restart() {
		GameFinish = false;
		startTiming = true;
        Role.transform.position = new Vector3(28.38f, 5f, 26.74f);
        Role.transform.eulerAngles = initRot;
		Role.gameObject.GetComponent<CapsuleCollider> ().isTrigger = false;
		timer_f = 0f;
		//        Role.transform.rotation = new Quaternion (0f, 90f, 0f, 0f);
    }


}
