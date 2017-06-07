using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour {

	public Vector3 rawMousePos;
	public Vector3 WorldMousePos;
	
	// Update is called once per frame
	void Update () 
	{
		rawMousePos = Input.mousePosition;


		WorldMousePos = Camera.main.ScreenToWorldPoint (rawMousePos); 
		WorldMousePos.z = 0f;
		this.transform.position = WorldMousePos;
		Cursor.visible = false; 
	}
}
