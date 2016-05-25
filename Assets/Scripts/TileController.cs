using UnityEngine;
using System.Collections;
using Mahjong;
using UnityEngine.UI;

public class TileController : MonoBehaviour {

 //   private bool isVisible=false;

    private Tile value;

    private Image face;


	// Use this for initialization
	void Start () {
        face = GetComponent<Image>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SetTile(Tile value)
    {
        this.value = value;

        GetComponent<Image>().sprite = this.value.face;
    }
}
