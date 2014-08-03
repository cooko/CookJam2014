using UnityEngine;
using System;

public class Level : MonoBehaviour {
	int width = 10; // number of squares wide
	int height = 10; // number of squares tall
	int square_size = 1;// size of th grid squares

	private Tile[,] grid;

	// Use this for initialization
	void Start () {
		grid = new Tile[width,height];
		//grid[0,0] = new Tile();
		for(int i = 0; i < width; i++){
			for(int j = 0; j < height; j++){
				grid[i,j] = gameObject.gameObject.AddComponent("Tile") as Tile;
			}
		}
		//print(grid[0,0]);
	}
	
	// Update is called once per frame
	void Update () {

	}
	public Tile getTile(float x, float y){
		int xg = (int)Math.Ceiling(x/square_size);
		int yg = (int)Math.Ceiling(y/square_size);
		//print("Player Pos: " + x + "," + y + " Grid Pos: " + xg + " ," + yg);
		if (xg >= 0 && yg >= 0 ){
			print(grid[xg,yg].state);
			return grid[xg,yg];
		}
		return null;
	}
}
