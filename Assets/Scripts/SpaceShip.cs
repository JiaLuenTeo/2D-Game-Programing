using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour {

	public GameObject Bullet; // Basic Projectile
	public Vector3 velocity;
	public float speed;
	public Crosshair crosshair;
	public Vector3 direction;
	public float rotSpeed;

	// Use this for initialization
	void Awake ()
	{
		Debug.Log ("I have awaken");
	}

	void Start () 
	{
		Debug.Log ("Let's get going!");
	}

	void OnEnable() 
	{
		Debug.Log ("ENABLING systems");
	}
	
	// Update is called once per frame
	void Update () 
	{
		Orientation(); 
		Movement ();
		Fire ();

	}

	void Orientation ()
	{
		direction = crosshair.WorldMousePos - this.transform.position;
		direction.Normalize ();
		float angle = Mathf.Atan2(direction.y,direction.x) * Mathf.Rad2Deg;

		this.transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0,0,angle-90), Time.deltaTime * rotSpeed); 

 	}

	void Movement()
	{
		velocity.x = Input.GetAxis ("Horizontal") * Time.deltaTime * speed;
		velocity.y = Input.GetAxis ("Vertical") * Time.deltaTime * speed;

		this.transform.Translate (velocity * Time.deltaTime * speed);
	}

	void Fire()
	{
		if (Input.GetButtonDown("Fire1"))
		{
			Instantiate (Bullet, this.transform.position, this.transform.rotation);
		}
	}
}
