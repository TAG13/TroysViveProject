using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatMovement : MonoBehaviour {

	Transform player;
	float speed = 3;

	void Awake (){
		player = GameObject.FindGameObjectWithTag ("MainCamera").transform;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//rotate to look at player
		transform.LookAt (player.position);
		transform.Rotate (new Vector3 (0, -90, 0), Space.Self);

		//move towards player
//		if (Vector3.Distance (transform.position, player.position) > attack1Range) 
//		{
			transform.Translate (new Vector3 (speed * Time.deltaTime, 0, 0));
//		}
	}
}
