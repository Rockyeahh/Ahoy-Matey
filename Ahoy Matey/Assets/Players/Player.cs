using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Networking;

public class Player : NetworkBehaviour {

    private Vector3 inputValue; // What? Why? How? 

    // Update is called once per frame
    void Update()
    {
        if (!isLocalPlayer) // How does this help or stop the bellow code? I'll never answer this, will I.
        {
            return;
        }

            inputValue.x = CrossPlatformInputManager.GetAxis("Horizontal");
            inputValue.y = 0f;
            inputValue.z = CrossPlatformInputManager.GetAxis("Vertical");

            transform.Translate(inputValue);
    }

    public override void OnStartLocalPlayer()
    {
            GetComponentInChildren<Camera>().enabled = true; // I don't know.
    }

}
