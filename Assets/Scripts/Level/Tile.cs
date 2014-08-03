using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour {

	public short state = 0;

	// Use this for initialization
	void Start () {
		//print("tile");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void SetState(short new_state){
		state = new_state;
	}
}
