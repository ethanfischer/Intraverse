﻿using UnityEngine;
using System.Collections;

public class SkyboxManager : MonoBehaviour
{
	public Camera cameraRight;
	public Camera cameraLeft;
	private Skybox skyboxRight;
	private Skybox skyboxLeft;

	public LevelManager levelManager;
	public Material[] materials;

	// Use this for initialization
	void Start ()
	{
		SetInitialReferences ();
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void SetInitialReferences ()
	{
		skyboxLeft = GameObject.FindGameObjectWithTag ("MainCameraLeft").GetComponent<Skybox> ();
		skyboxRight = GameObject.FindGameObjectWithTag ("MainCameraRight").GetComponent<Skybox> ();
//		eventMasterScript = GameObject.Find ("GameManager").GetComponent<GameManager_EventMaster> (); no longer needed because events are static
		GameManager_EventMaster.NextLevelEvent += NextLevel; //Subcribe NextLevel() to the NextLevelEvent
//		eventMasterScript.DropCeiling += DropCeiling;

	}

	void NextLevel ()
	{
//		Debug.Log ("NextLevel");
//		Material m = GetSkyboxMaterial ();
//		Debug.Log ("Material t:" + t);
//		SetSkyboxMaterial (m);

	}


	//	public void SetSkyboxMaterial (Material m)
	//	{
	//		// Get each skybox
	//		if (skyboxRight != null && skyboxLeft != null) {
	////			skyboxRight = cameraRight.GetComponent<Skybox> ();
	////			skyboxLeft = cameraLeft.GetComponent<Skybox> ();
	////			Debug.Log ("skyboxRIght.material" + skyboxRight.material);
	//			// set skyboxes' material
	//			skyboxRight.material = m;
	//			skyboxLeft.material = m;
	////			skyboxRight.transform.Rotate ();
	//
	////			Debug.Log ("skyboxRIght.material" + skyboxRight.material);
	//		} else {
	//			Debug.Log ("no skyboxes");
	//		}
	//
	//	}

	//	Material GetRandomSkyboxMaterial ()
	//	{
	//		//TODO
	//		// 1. Given an array of Materials, pick one that has not been shown and return it
	//		Material m =
	//	}

	//	Material GetSkyboxMaterial ()
	//	{
	////		Debug.Log (materials [i].name);
	////		int lc = LevelManager.GetLevelCount ();
	//////		Debug.Log ("lc: " + lc);
	////		return materials [lc - 1]; //Level 1 corresponds with materials[0], Level2 with materials[1], etc.
	//	}
}
