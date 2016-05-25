using UnityEngine;
using System.Collections;
using Mahjong;
using System;
using System.Collections.Generic;

public class HandController : MonoBehaviour {

    [SerializeField]
    GameObject prefab;

    [SerializeField]
    WallController wall;

    List<Tile> Hand;

	// Use this for initialization
	IEnumerator Start () {
        GameObject tile;
        Hand = new List<Tile>();
        yield return new WaitForSeconds(0.1f);
        for (int i = 0; i < 13; i++)
        {
            Hand.Add(wall.GetTile());
        }

        Hand.Sort();

        for (int i = 0; i < 13; i++)
        {
            tile = Instantiate(prefab);
            tile.transform.SetParent(transform, false);
            tile.GetComponent<TileController>().SetTile(Hand[i]);
        }
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
