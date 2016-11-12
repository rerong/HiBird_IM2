using UnityEngine;
using System.Collections;

public class LovePerSec : MonoBehaviour 
{
	public canvasManager canvas;
    private float totalLPS = 0.0f; //Love Per Second
	private int totalLPSUnit = 64;
	private string totalLPSStrUnit = null;
	private loveCalc calc = new loveCalc();
    public lpsItemManager[] items;

    void Start() {
		StartCoroutine(AutoTick());
    }

    void Update() 
	{
		calcTotal ();
		canvas.gameManaging.setLPS (totalLPS, totalLPSUnit, totalLPSStrUnit);

    }

	public void calcTotal()
	{
		totalLPS = 0;
		foreach(lpsItemManager item in items) 
		{
			calc.addCalc (totalLPS, totalLPSUnit, item.objLPS, item.objUnit);
			totalLPS = calc.returnChangeCost();
			totalLPSUnit = calc.returnChangeNumUnit ();
			totalLPSStrUnit = calc.returnChangeUnit ();
		}
	}

    public void AutoGoldPerSec() 
	{
		calc.addCalc (canvas.gameManaging.getLove(), canvas.gameManaging.getLoveUnit(), totalLPS/10, totalLPSUnit);
		canvas.gameManaging.setLove(calc.returnChangeCost(), calc.returnChangeNumUnit(), calc.returnChangeUnit());
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
