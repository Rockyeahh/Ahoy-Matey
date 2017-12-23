using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Networking;

public class PlayerNetwork : NetworkBehaviour {

    private Vector3 inputValue; // What? Why? How? 

    public float rotationSpeed = 1F;
    public float speed = 10.0F;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!isLocalPlayer) // How does this help or stop the bellow code? I'll never answer this, will I.
        {

            return;
        }

            float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
            transform.Rotate(0, rotation, 0);
            inputValue.y = 0f;
            float translation = Input.GetAxis("Vertical") * speed;
            translation *= Time.deltaTime;
            transform.Translate(0, 0, translation);

        transform.Translate(inputValue);

    }

    public override void OnStartLocalPlayer()
    {
            GetComponentInChildren<Camera>().enabled = true; // It makes the localplayer enable the camera, which stops it from having two in the game window.
            GetComponentInChildren<AudioListener>().enabled = true;
    }

}
