﻿using UnityEngine;
using System.Collections;

public class HexTile:MonoBehaviour {

	public Vector2 location;
	public Sprite normalSprite;
	public Sprite highLightSprite;
	public Map map;
	public int hexWidth;
	public int hexHeight;
	public Vector2 position;
	public Vector2 center;



	// Use this for initialization
	void Start () {
		this.center = 
	}


	
	// Update is called once per frame
	void Update () {
	
	}

	void highlight(){
		SpriteRenderer sr = this.GetComponent<SpriteRenderer>();
		sr.sprite = highLightSprite;
	}

	public void deselect(){
		SpriteRenderer sr = this.GetComponent<SpriteRenderer>();
		sr.sprite = normalSprite;
	}

	public void setWidthAndHeight(){

		SpriteRenderer sr = this.GetComponent<SpriteRenderer>();
		this.hexWidth =  sr.sprite.texture.width;
		this.hexHeight = sr.sprite.texture.height;
	}


}