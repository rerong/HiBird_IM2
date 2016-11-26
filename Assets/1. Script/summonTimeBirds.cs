using UnityEngine;
using System.Collections;

public class summonTimeBirds : MonoBehaviour {

    public canvasManager canvas;

    [Range(-100f, 100f)]
    public float summonTime;
    private int maxBird = 25;

    // Use this for initialization
    void Start()
    {
        canvas.birdTimeSummonBtn.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        canvas.sumonBirdSilder.value += Time.deltaTime / summonTime;

        if (canvas.sumonBirdSilder.value == 1)
            canvas.birdTimeSummonBtn.interactable = true;

    }

    public void clicked()
    {
        if (canvas.flockcontroller._childAmount < maxBird)
        {
            canvas.summonBird.setSummon ();
            canvas.sumonBirdSilder.value = 0;
            canvas.birdTimeSummonBtn.interactable = false;
        }
    }
}
