using UnityEngine;
using System.Collections;

public class birdcheck : MonoBehaviour {

    public FlockController flockcontroller;
    public UnityEngine.UI.Text birdText;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        birdText.text = flockcontroller._childAmount + " / " + "25";
    }

}
