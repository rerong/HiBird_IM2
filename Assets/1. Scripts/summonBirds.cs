using UnityEngine;
using System.Collections;

public class summonBirds : MonoBehaviour {

    public canvasManager canvas;
    
	public lpsItemManager[] items;
	public treeLovePerClick treeLPC;

    private int maxBird = 25;
    private bool summon = false;

    [Range(-100f, 100f)]
    public float summonTime;

    // Use this for initialization
    void Start () {
        canvas.birdTimeSummonBtn.interactable = false;
    }

// Update is called once per frame
	void Update () 
	{
        if (summon)
        {
            if (canvas.flockcontroller._childAmount < maxBird)
            {
                summon = false;
                canvas.flockcontroller._childAmount += 1;
            }
        }

        canvas.summonBirdSilder.value += Time.deltaTime / summonTime;
        if (canvas.summonBirdSilder.value == 1)
            canvas.birdTimeSummonBtn.interactable = true;

    }

    public void clicked()
    {
            if (canvas.flockcontroller._childAmount < maxBird)
            {
                summon = false;
                canvas.flockcontroller._childAmount += 1;
                canvas.birdTimeSummonBtn.interactable = false;
                canvas.summonBirdSilder.value = 0;
            }
            else
            {
                canvas.birdTimeSummonBtn.interactable = false;
            }
    }

    public void setSummon()
    {
        summon = true;
    }
}
