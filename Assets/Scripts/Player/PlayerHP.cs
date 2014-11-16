using UnityEngine;
using System.Collections;

public class PlayerHP : MonoBehaviour {
	public int MaxHP;
	public int CurrentHP;

	public float HPBoxLenght=Screen.width / 3;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI(){

		if (CurrentHP > 0) {
						GUI.Box (new Rect (10, 10, HPBoxLenght / (MaxHP / CurrentHP), 20), CurrentHP + "/" + MaxHP);
				}

	}

	void AdjustCurrentHP(int AdjustHP){
		CurrentHP += AdjustHP;
		if (CurrentHP > AdjustHP) {
			CurrentHP=MaxHP;
				}
		}
}
