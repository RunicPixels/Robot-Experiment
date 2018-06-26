using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggered : MonoBehaviour {
    public bool hasSwitch;
    public GameObject text;
    public Animator anim;
    public GameObject explosion;
    public GameObject robot;
    private bool inside;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (inside == true && Input.GetKeyDown(KeyCode.F)) {
            explosion.SetActive(true);
            robot.SetActive(false);
        }
	}

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player") {
            inside = true;
            text.SetActive(true);
            if(hasSwitch) anim.SetTrigger("GoSad");
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.tag == "Player") {
            inside = false;
            text.SetActive(false);
            if(hasSwitch) anim.SetTrigger("GoIdle");
        }
    }
}
