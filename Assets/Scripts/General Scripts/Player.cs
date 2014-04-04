﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player:MonoBehaviour  {
	public GameObject player;
	public Sprite normalSprite;
	int numMoveTiles = 1;
	//GameObject Map;








	public void move(GameObject hextile){

		//set the location equal to the corresponding tile's position
		//if checking the map reveals that the move is okay{
		HexTile hexscript = hextile.GetComponent<HexTile>();
		this.player.transform.position = hexscript.center;
		//remove self from occupant of previous tile
		//put this one as occupied
		hexscript.occupant = this.player;
		hexscript.deselect();
		//}

	}//move
}
