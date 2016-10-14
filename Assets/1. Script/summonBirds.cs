using UnityEngine;
using System.Collections;

public class summonBirds : MonoBehaviour {

	public FlockController flockcontroller;
	private int maxBird = 25;
	private int totalLPSLevel = 0;
	public lpsItemManager[] items;
	public treeLovePerClick treeLPC;
	private bool clicked = false;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () 
	{
		foreach(lpsItemManager item in items) {
			totalLPSLevel += item.getLevel();
		}
		if(clicked)
		{
			if (flockcontroller._childAmount < maxBird && treeLPC.getLevel() % 50 == 0)
			{
				clicked = false;
				flockcontroller._childAmount += 1;
			}
		}

	}
	public void setClicked()
	{
		clicked = true;
	}
}
