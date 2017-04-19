using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beatTest : MonoBehaviour {

	public bool beat;

	// Use this for initialization
	void Start () {
		StartCoroutine (BeatRoutine());
	}


	void Update ()
	{
		Debug.Log ("Beat " + beat);
	}

	private IEnumerator BeatRoutine ()
	{
		while (true) 
		{
			yield return new WaitForSeconds (0.4f);
			beat = true;
			yield return new WaitForSeconds (0.1f);
			beat = false;
		}
	}


}
