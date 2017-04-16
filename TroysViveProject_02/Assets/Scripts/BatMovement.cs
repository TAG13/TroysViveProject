using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatMovement : MonoBehaviour {

	Transform player;
	float speed = 3;

	void Awake (){
		player = GameObject.FindGameObjectWithTag ("Player").transform;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//rotate to look at player
//		transform.LookAt (player.position);

		transform.position = Vector3.MoveTowards (transform.position, player.position, 0.5f * Time.deltaTime);


//		transform.Rotate (new Vector3 (0, -90, 0), Space.Self);
//		transform.rotation = Quaternion.LookRotation (transform.position, player.position, transform.up);

		//move towards player
//		if (Vector3.Distance (transform.position, player.position) > 0.1) 
//		{
//			transform.Translate (new Vector3 (speed * Time.deltaTime, 0, 0));
//		}
	}
}
