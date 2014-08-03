using UnityEngine;
using System;

public class Level : MonoBehaviour {
	int width; // number of squares wide
	int height; // number of squares tall
	int square_size = 1;// size of th grid squares

	private Tile[,] grid;

	// Use this for initialization
	void Start () {
		grid = new Tile[10,10];
		getTile(16,32);
	}
	
	// Update is called once per frame
	void Update () {

	}
	public Tile getTile(float x, float y){
		int xg = (int)Math.Ceiling(x/square_size);
		int yg = (int)Math.Ceiling(y/square_size);
		print("Player Pos: " + x + "," + y + " Grid Pos: " + xg + " ," + yg);
		//if (xg >= 0 && yg >= 0 ){
		//	return grid[xg,yg];
		//}
		return null;
	}
}
