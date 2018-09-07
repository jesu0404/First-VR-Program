using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonClick : MonoBehaviour {

    public ballPrefab ballPrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
        {
            ballPrefab ball = Instantiate<ballPrefab>(ballPrefab);
            ball.transform.localPosition = transform.position;
            ball.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * Random.Range(1000, 1250));
        }
	}
}
