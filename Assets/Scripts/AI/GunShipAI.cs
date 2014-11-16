using UnityEngine;
using System.Collections;

public class GunShipAI : MonoBehaviour {
	public float Speed;
	public Vector3 VelocityVector;



	public GameObject shot;

	public float fireRate;
	private float nextFire;

	//After spawning you fly to this


	//

	//personal transform


	//


	// Use this for initialization


	void Start () {

				//Setting the way the ship moves across the game 
				/*{
						Vector3 TargetPosition = EndPoint;
		
						Vector3 CurrentPosition = this.transform.position;

						VelocityVector = EndPoint - CurrentPosition;

						VelocityVector.Normalize ();
						VelocityVector *= Speed;

						rigidbody.velocity = VelocityVector;
				}*/

		rigidbody.velocity=new Vector3(Speed,0,0);


		//setting the way it points
		if (Speed < 0) {
				Quaternion ShootAt = Quaternion.Euler (0, -90, 0);
				this.transform.rotation=(ShootAt);
		} 
		else {
				Quaternion ShootAt = Quaternion.Euler (0, 90, 0);
				this.transform.rotation=(ShootAt);
		}

	


	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextFire)
		{
			AI_Attack ();
		}
	

	}

	void AI_move(){

	}

	void AI_Attack(){
		nextFire = Time.time + fireRate;
		Quaternion ShootAt = Quaternion.Euler (0, 180,0 );
		Instantiate(shot, this.transform.position,ShootAt );

	}


}
