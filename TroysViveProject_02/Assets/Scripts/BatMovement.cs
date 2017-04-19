using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatMovement : MonoBehaviour {

	Transform player;
	float speed = 1;

	void Awake (){
		player = GameObject.FindGameObjectWithTag ("Player").transform;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//rotate to look at player
		transform.LookAt (player.position);

		transform.position = Vector3.MoveTowards (transform.position, player.position, speed * Time.deltaTime);

	}
}
