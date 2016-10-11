using UnityEngine;
using System.Collections;

public class click : MonoBehaviour {

    public FlockController flockcontroller;

    public void clicked() {
        if(flockcontroller._childAmount < 25)
        {
            flockcontroller._childAmount = flockcontroller._childAmount + 1;
        }
    }
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
