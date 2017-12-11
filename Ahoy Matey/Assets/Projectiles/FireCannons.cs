using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCannons : MonoBehaviour {

    public GameObject cannonBallRight, cannonBallLeft, cannonBallHolder;

    private GameObject projectileParent;

    // Use this for initialization
    void Start () {
        projectileParent = GameObject.Find("projectiles");
        if (projectileParent == null)
        {
            projectileParent = new GameObject("projectiles");
        }
    }
	
	// Update is called once per frame
	void Update () {
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
        GameObject newProjectile2 = Instantiate(cannonBallLeft) as GameObject;
        newProjectile2.transform.parent = projectileParent.transform;
        newProjectile2.transform.position = cannonBallHolder.transform.position;
    }

    private void Fire2()
    {
        GameObject newProjectile1 = Instantiate(cannonBallRight) as GameObject;
        newProjectile1.transform.parent = projectileParent.transform;
        newProjectile1.transform.position = cannonBallHolder.transform.position;
    }

}
