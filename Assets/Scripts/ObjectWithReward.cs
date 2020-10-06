using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectWithReward : MonoBehaviour {

    public string reward;


    private Collider2D c2d;
	// Use this for initialization
	void Start () {
        c2d = GetComponent<Collider2D>();
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            if ( reward == "Double Jump")
            {
                col.SendMessage("EnableDoubleJump", true);
            }
        }
    }
}
