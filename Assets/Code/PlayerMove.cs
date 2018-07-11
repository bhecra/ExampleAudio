using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.AddComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.UpArrow))
		{
			transform.position += transform.forward * Time.deltaTime;
		}

	}
}
