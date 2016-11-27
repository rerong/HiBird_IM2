using UnityEngine;
using System.Collections;

public class LovePerSec : MonoBehaviour 
{
	public canvasManager canvas;
    private float totalLPS = 0.0f; //Love Per Second
	private int totalLPSUnit = 64;
	private string totalLPSStrUnit = null;
	private bool skillOn = false;
	private float increment;
	private loveCalc calc = new loveCalc();
    public groundManager groundLPS;
    public rockManager [] rockLPS;
    public mountainManager [] mountainLPS;

    void Start() {
		StartCoroutine(AutoTick());
    }

    void Update() 
	{
		calcTotal ();
		if (skillOn == true) 
		{
			totalLPS *= increment;

			if (calc.changeCalcLove (totalLPS, totalLPSUnit)) 
			{
				this.totalLPS = calc.returnChangeCost ();
				this.totalLPSUnit = calc.returnChangeNumUnit ();
				this.totalLPSStrUnit = calc.returnChangeUnit ();
			} 
		}
		canvas.gameManaging.setLPS (totalLPS, totalLPSUnit, totalLPSStrUnit);
    }

	void calcTotal()
	{
		totalLPS = 0;
		totalLPSUnit = 64;

		if (groundLPS.getShow() == true) 
		{
			calc.addCalc (totalLPS, totalLPSUnit, groundLPS.getObjLPS(), groundLPS.getObjUnit());
			totalLPS = calc.returnChangeCost();
			totalLPSUnit = calc.returnChangeNumUnit ();
			totalLPSStrUnit = calc.returnChangeUnit ();
		}

		foreach(rockManager rock in rockLPS) 
		{
			if (rock.getShow() == true) 
			{
				calc.addCalc (totalLPS, totalLPSUnit, rock.getObjLPS(), rock.getObjUnit());
				totalLPS = calc.returnChangeCost();
				totalLPSUnit = calc.returnChangeNumUnit ();
				totalLPSStrUnit = calc.returnChangeUnit ();
			}
		}

		foreach(mountainManager mountain in mountainLPS) 
		{
			if (mountain.getShow() == true) 
			{
				calc.addCalc (totalLPS, totalLPSUnit, mountain.getObjLPS(), mountain.getObjUnit());
				totalLPS = calc.returnChangeCost();
				totalLPSUnit = calc.returnChangeNumUnit ();
				totalLPSStrUnit = calc.returnChangeUnit ();
			}
		}
	}

	public void setSkillOn(float rate)
	{
		skillOn = true;
		increment = rate;
	}

	public void setSkillOff()
	{
		skillOn = false;
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
