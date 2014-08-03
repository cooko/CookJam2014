using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour {

	protected short state = 0;

	// Use this for initialization
	void Start () {
		//print("tile");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	short GetState(){
		return state;
	}
	void SetState(short new_state){
		state = new_state;
	}
}
