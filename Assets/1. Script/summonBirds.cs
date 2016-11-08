using UnityEngine;
using System.Collections;

public class summonBirds : MonoBehaviour {

	public FlockController flockcontroller;
	private int maxBird = 25;
	public lpsItemManager[] items;
	public treeLovePerClick treeLPC;
	private bool summon = false;

// Use this for initialization
	void Start () {

	}

// Update is called once per frame
	void Update () 
	{
		if(summon)
		{
			if (flockcontroller._childAmount < maxBird)
			{
				summon = false;
				flockcontroller._childAmount += 1;
			}
		}

	}
	public void setSummon()
	{
		summon = true;
	}
}
