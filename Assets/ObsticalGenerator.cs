using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class ObsticalGenerator : MonoBehaviour {

    public Tilemap tMap;
    public Tile tile;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3Int  coord = new Vector3Int(1, 1, 1);
        Vector3Int coord2 = new Vector3Int(10, 10, 10);
        tMap.BoxFill(coord2, tile, -10-10,-10,10,10);


    }
}
