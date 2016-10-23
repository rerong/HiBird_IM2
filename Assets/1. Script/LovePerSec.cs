using UnityEngine;
using System.Collections;

public class LovePerSec : MonoBehaviour 
{
	public canvasManager canvas;
    private float totalLPS = 0.0f; //Love Per Second

    public lpsItemManager[] items;

    void Start() {
		StartCoroutine(AutoTick());
    }

    void Update() {
        canvas.lpsDisplay.text = getTotalLPS().ToString("F0")+ "sec";

    }

    public float getTotalLPS() 
    {
        totalLPS = 0;
        foreach(lpsItemManager item in items) 
        {
            totalLPS += item.objLPS;
        }
        return totalLPS;
    }

    public void AutoGoldPerSec() {
		canvas.gameManaging.setLove(canvas.gameManaging.getLove() + totalLPS/10);
    }

    IEnumerator AutoTick() 
    {
        while (true)
        {
            AutoGoldPerSec();
            yield return new WaitForSeconds(0.10f); //0.1s
        }
    }
}
