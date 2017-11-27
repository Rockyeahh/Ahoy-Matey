using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {

    public void MyStartHost()
    {
        Debug.Log(Time.timeSinceLevelLoad + " Starting host.");
        StartHost();
    }

    public override void OnStartHost()
    {
        Debug.Log(Time.timeSinceLevelLoad + " Host started.");
    }

    public override void OnStartClient(NetworkClient myClient) // Called when the client start is requested.
    {
        Debug.Log(Time.timeSinceLevelLoad + " Client start requested.");
        InvokeRepeating("PrintDots", 0f, 1f); // Invokes dots every 1f until it connects to the client. No clue what the 0f is for.
    }

    public override void OnClientConnect(NetworkConnection conn) // Called when the client is connected to the server.
    {
        Debug.Log(Time.timeSinceLevelLoad + " Client is now connected to IP: " + conn.address); // It takes the local conn, finds the IP address of the host. In this case it'll say local server.
        CancelInvoke();
    }

    void PrintDots()
    {
        Debug.Log(".");
    }

}
