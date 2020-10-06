using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {

    public float Speed = 1.5f;

    private Vector2 bgPos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        MoveBackground();
	}

    void MoveBackground()
    {
        bgPos += new Vector2( Time.deltaTime*Speed, 0 );
        GetComponent<Renderer>().material.mainTextureOffset = bgPos;
    }
}
