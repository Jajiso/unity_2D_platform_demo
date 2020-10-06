using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectWithDamage : MonoBehaviour {


    private PolygonCollider2D owd;
	// Use this for initialization
	void Start () {
        owd = GetComponent<PolygonCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" )
        {
            collision.SendMessage("EnemyKnockBack", transform.position.x);
        }
    }
}
