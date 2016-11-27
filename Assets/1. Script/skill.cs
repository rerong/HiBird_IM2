using UnityEngine;
using System.Collections;

public class skill : MonoBehaviour 
{
	public canvasManager canvas;
	private float lpcIncrement = 2.0f;
	private bool lpcIncreaseOn = false;
	private float lpsIncrement = 2.0f;
	private bool lpsIncreaseOn = false;
	private float loveIncrement = 300.0f;
	private loveCalc calc = new loveCalc();
	void Start () 
	{

	}
	void Update () 
	{
		/*if (lpcIncreaseOn == true)  //and lpcIncreaseBar.value == 1 -> time out
		{
			lpcIncreaseOn = false;

			float lpc = canvas.gameManaging.getLPC ();
			int lpcUnit = canvas.gameManaging.getLPCUnit();

			lpc /= lpcIncrement;

			if (lpc < 1) 
			{
				lpcUnit -= 1;
				lpc *= 1000;
			}

			canvas.gameManaging.setLPC (lpc, lpcUnit);
		}

		if (lpsIncreaseOn == true) 
		{
			lpsIncreaseOn = false;
			canvas.lovePerSecond.setSkillOff ();
		}*/
	}

	public void skillLPCIncrease()
	{
		lpcIncreaseOn = !lpcIncreaseOn;
		float lpc = canvas.gameManaging.getLPC ();
		int lpcUnit = canvas.gameManaging.getLPCUnit();

		if (lpcIncreaseOn == true)
			lpc *= lpcIncrement;
		else 
		{
			lpc /= lpcIncrement;

			if (lpc < 1) 
			{
				lpcUnit -= 1;
				lpc *= 1000;
			}
		}

		canvas.gameManaging.setLPC (lpc, lpcUnit);
		Debug.Log ("test" + lpcIncreaseOn);
	}

	public void skillLPSIncrease()
	{
		lpsIncreaseOn = !lpsIncreaseOn;
		if(lpsIncreaseOn == true)
			canvas.lovePerSecond.setSkillOn (lpsIncrement);
		else
			canvas.lovePerSecond.setSkillOff ();
	}

	public void skillLoveIncrease()
	{
		float lpc = canvas.gameManaging.getLPC ();
		int lpcUnit = canvas.gameManaging.getLPCUnit();

		lpc *= loveIncrement;
		if (lpc >= 1000) 
		{
			lpc /= 1000;
			lpcUnit++;
		}

		calc.addCalc (canvas.gameManaging.getLove(), canvas.gameManaging.getLoveUnit(), lpc, lpcUnit);
		canvas.gameManaging.setLove(calc.returnChangeCost(), calc.returnChangeNumUnit(), calc.returnChangeUnit());
	}
}
