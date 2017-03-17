using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Rigibody : MonoBehaviour {
    public float speed;
    private Rigidbody _rigibody;
	// Use this for initialization
	void Start () {

        _rigibody = GetComponent<Rigidbody>();

            	
	}
	
	// Update is called once per frame
	void Update () {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical);
        _rigibody.AddForce(direction * speed);
	}
}
