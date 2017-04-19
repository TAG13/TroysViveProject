using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileDestroy : MonoBehaviour {

	public float lifetime;

	void Start ()
	{
		Destroy (gameObject, lifetime);
	}
	


	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "Enemy") 
		{
			//Debug.Log ("Hit enemy whatevs");
			//basically don't do anything
		} 

		else if (col.gameObject.tag == "Projectile") 
		{
			//Debug.Log ("Hit projectile whatevs");
			//basically don't do anything
		} 

		else if (col.gameObject.tag == "Player") 
		{
			//take away player health
			//play sfx

			Destroy (gameObject);
		} 

		// if it hits the environment or anything that should block the projectiles
		else 
		{
			Destroy (gameObject);
		}

	}



}
