using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour
{
	public float Speed;
	Vector3 Target;
	void Start ()
	{
		rigidbody.velocity = transform.forward * Speed;
	}


	void SetUp(Vector3 Target){
		//Setting the way the ship moves across the game 


			
			Vector3 CurrentPosition = this.transform.position;
			
			Vector3 VelocityVector = Target - CurrentPosition;
			
			VelocityVector.Normalize ();
			VelocityVector *= Speed;
			
			rigidbody.velocity = VelocityVector;

		//setting the way it points
		this.transform.LookAt(VelocityVector);

	}

}
