using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggered : MonoBehaviour {
    public bool hasSwitch;
    public GameObject text;
    public Animator anim;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player") {
            text.SetActive(true);
            if(hasSwitch) anim.SetTrigger("GoSad");
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.tag == "Player") {
            text.SetActive(false);
            if(hasSwitch) anim.SetTrigger("GoIdle");
        }
    }
}
