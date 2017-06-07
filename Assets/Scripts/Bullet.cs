using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public float bulletSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//transform.translate (new Vector3 (0f, 1f, 0f));
		transform.Translate(Vector3.up * Time.deltaTime * bulletSpeed);
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (!other.CompareTag ("Player")) {
			other.transform.localScale *= 0.5f;
		}
	}
}
