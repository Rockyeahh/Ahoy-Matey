using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Networking;

public class FireCannons : NetworkBehaviour {

    public GameObject cannonBallRight, cannonBallLeft, cannonBallHolder;

    GameObject cannon;

    void Start () {
        cannon = GameObject.FindGameObjectWithTag("Cannons");

    }

	void Update () {

        if (!isLocalPlayer)
        {
            Debug.Log("Is not the same player.");
            return;
        }
		if (Input.GetButtonDown("Fire1")) // Left
        {
            Fire1();
        }

        if (Input.GetButtonDown("Fire2")) // Right
        {
            Fire2();
        }
    }

    private void Fire1()
    {
        if (!isLocalPlayer)
        {
            Debug.Log("Is not the same player.");
            return;
        }
        GameObject cannonBallInstance = Instantiate(cannonBallLeft, cannonBallHolder.transform) as GameObject; // Creates an instance and instantitates the cannon ball and cannonballholder.transform inside it.
        cannonBallInstance.transform.position = cannon.transform.position; // Sets the Instance.transform.position to the cannon transform.position.
    }

    private void Fire2()
    {
        GameObject cannonBallInstance = Instantiate(cannonBallRight, cannonBallHolder.transform) as GameObject;
        cannonBallInstance.transform.position = cannon.transform.position;
    }

}
