using UnityEngine;
using System.Collections;
using System;
using Mahjong;
using System.Collections.Generic;



public class WallController : MonoBehaviour {

    private List<Tile> collection = new List<Tile>();

    // Use this for initialization
    void Start () {
        for (Suit i = Suit.manzu; i != Suit.yakuhai; i++)
        {
            for (int j = 1; j < 10; j++)
            {
                int num = 4;
                if (j == 5)
                    num = 3;
                for (int k = 0; k < num; k++)
                    collection.Add(new Tile(j, i));
            }
            collection.Add(new Tile(10, i));
        }
        for (int i = 1; i < 8; i++)
            for (int j = 0; j < 4; j++)
                collection.Add(new Tile(i, Suit.yakuhai));

        Shuffle();
        Debug.Log("loaded");
    }

	public Tile GetTile()
    {
        Tile temp = collection[0];
        collection.RemoveAt(0);
        return temp;
    }


	// Update is called once per frame
	void Update () {
	
	}

    void Shuffle()
    {
        for (int i = 0; i < collection.Count; i++)
        {
            Tile temp = collection[i];
            int num = UnityEngine.Random.Range(0, collection.Count);
            collection[i] = collection[num];
            collection[num] = temp;

        }
    }
}
