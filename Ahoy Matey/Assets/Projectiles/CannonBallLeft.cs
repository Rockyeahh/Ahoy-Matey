using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBallLeft : MonoBehaviour {

    public float speed, damage;
    public float launchForce;

    public GameObject cannons;

    Rigidbody rigidBody;

    void Start () {
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.AddForce(-transform.parent.transform.right * launchForce, ForceMode.Impulse);
    }
	
	void Update () {

    }
}
