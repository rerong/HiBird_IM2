using UnityEngine;
using System.Collections;

public class cloudchild : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (gameObject.transform.position.x > 0)
            gameObject.transform.Translate(-255,0,0);
	}
}
