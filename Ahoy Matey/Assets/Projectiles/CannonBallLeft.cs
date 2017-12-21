using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBallLeft : MonoBehaviour {

    public float speed, damage;
    public float launchForce;

    public GameObject cannons;

    Rigidbody rigidBody;

    // Use this for initialization
    void Start () {
        rigidBody = GetComponent<Rigidbody>();
        // Maybe they need to set their transform to the same as the player ship here, before firing.
        rigidBody.AddForce(-transform.parent.transform.right * launchForce, ForceMode.Impulse);
    }
	
	// Update is called once per frame
	void Update () {
       // rigidBody.velocity = -transform.right * speed * Time.deltaTime; // Port is left.
       // print("Fire left");
    }
}
