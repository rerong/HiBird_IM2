using UnityEngine;
using System.Collections;

public class summonBirds : MonoBehaviour {

    public canvasManager canvas;
    private bool summon = false;
    private int maxBird = 25;

    // Use this for initialization
    void Start () {
	}

// Update is called once per frame
	void Update () 
	{
		if(summon)
		{
			if (canvas.flockcontroller._childAmount < maxBird)
			{
				summon = false;
                canvas.flockcontroller._childAmount += 1;
			}
		}

    }

    public void setSummon()
	{
		summon = true;
	}
}
