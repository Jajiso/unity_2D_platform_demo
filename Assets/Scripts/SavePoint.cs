using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePoint : MonoBehaviour {

    private bool hasSavePoint = false;
	// Use this for initialization
	void Start ()
    {

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player" && !hasSavePoint)
        {
            col.SendMessage("SavedPosition", new Vector3(transform.position.x, transform.position.y, 0) );
            hasSavePoint = true;
            var green = transform.GetChild(1);
            green.transform.position = new Vector3(green.transform.position.x, green.transform.position.y, 1);
        }
    }
}
