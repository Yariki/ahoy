using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class HUDManager : MonoBehaviour 
{

    NetworkManager netwokManager;

	// Use this for initialization
	void Start () 
    {
        netwokManager = GetComponent<NetworkManager>();
	}
	

    public void StartHost()
    {
        if(netwokManager)
        {
            Debug.Log("Host starting " + Time.timeSinceLevelLoad);    
            netwokManager.StartHost();
        }    
    }

    void OnStartHost()
    {
        Debug.Log("Host started " + Time.timeSinceLevelLoad);    
    }
	
}
