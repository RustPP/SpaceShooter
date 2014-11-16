using UnityEngine;
using System.Collections;

public class RockSpinScript : MonoBehaviour {

	// Use this for initialization
	public float tumble;
	
	void Start ()
	{
		rigidbody.angularVelocity = Random.insideUnitSphere * tumble; 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}


