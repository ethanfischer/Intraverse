﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace Chapter1
{   
  public class Welcome : MonoBehaviour
  {

    public string myMessage = "Welcome";
    private Text textWelcome;
    public GameObject canvasWelcome;

	// Use this for initialization
	void Start () {
	   MyWelcomeMessage();
       SetInitialReferences();
	}
    
    void SetInitialReferences () 
    {
        textWelcome = GameObject.Find("TextWelcome").GetComponent<Text>();
    }
    
    void MyWelcomeMessage()
    {
        if ((textWelcome != null))
        {
           textWelcome.text = myMessage;
        }
        else
        {
            Debug.LogWarning("Welcome Text Not Assigned!");
        }

        StartCoroutine(DisableCanvas(3.5f));

    }
    
    IEnumerator DisableCanvas(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        canvasWelcome.SetActive(false);
        
    }
}  
}


