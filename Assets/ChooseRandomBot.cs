using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseRandomBot : MonoBehaviour {
    public GameObject[] robotz;
	// Use this for initialization
	void Start () {
        robotz[Random.Range(0, robotz.Length)].SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
