﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacePoolObjects : MonoBehaviour {

	public Camera ARCamera;

	public GameObject[] PoolItemsPrefab;

	void Update(){
		if (Input.GetMouseButtonDown (0)) {
			TrySpawningItems (Input.mousePosition);
		}
	}

	public void TrySpawningItems(Vector2 screenPos){
		//RayCast from the screen position to see if we hit the water
		//if do, then create a random pool toy at that position
		GameObject randPoolItem = PoolItemsPrefab[Random.Range(0, PoolItemsPrefab.Length)];
		RaycastHit hit;
		if (Physics.Raycast(ARCamera.ScreenPointToRay(screenPos), out hit)) {
			Instantiate (randPoolItem, hit.point, Quaternion.identity);
		}
	}

}