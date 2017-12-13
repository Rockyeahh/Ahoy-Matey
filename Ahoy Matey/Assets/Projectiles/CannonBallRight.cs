using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBallRight : MonoBehaviour {

    public float speed, damage;
    public float launchForce;

    public GameObject cannons;

    Rigidbody rigidBody;

    void Start () {
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.AddForce(transform.parent.transform.right * launchForce, ForceMode.Impulse);
    }
	
	void Update () {
        // rigidBody.velocity = transform.right * speed * Time.deltaTime; // Starboard is right.
       // rigidBody.AddForce(new Vector3(speed * Time.deltaTime, 0, 0));
       // print("Fire right");
    }
}
