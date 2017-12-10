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
        // deactivate the CharacterController that is not Mine in the Network 
      //  if (!Network.isMine)
     //   {
          //  GetComponent<CharacterController>().enabled = false;
       //     GetComponentInChildren<AudioListener>().enabled = false;
       //     GetComponentInChildren<Camera>().enabled = false;
       // }
    }

    // Update is called once per frame
    void Update()
    {
        if (!isLocalPlayer) // How does this help or stop the bellow code? I'll never answer this, will I.
        {
         //   GetComponent<CharacterController>().enabled = false;
          //  GetComponentInChildren<AudioListener>().enabled = false;
          //  GetComponentInChildren<Camera>().enabled = false;
            return;
        }

            float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
           // rotation *= Time.deltaTime;  // This was causing it to not rotate? Not sure why.
            transform.Rotate(0, rotation, 0);
            // inputValue.x = CrossPlatformInputManager.GetAxis("Horizontal");
            inputValue.y = 0f;
            //inputValue.z = CrossPlatformInputManager.GetAxis("Vertical");
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
