using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBallLeft : MonoBehaviour {

    public float speed, damage;

    Rigidbody rigidBody;

    // Use this for initialization
    void Start () {
        rigidBody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        rigidBody.velocity = -transform.right * speed * Time.deltaTime; // Port is left.
        print("Fire left");
    }
}
