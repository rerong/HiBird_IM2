using UnityEngine;
using System.Collections;

public class skill : MonoBehaviour 
{
	public canvasManager canvas;
	private float lpcIncrement = 2.0f;
	private bool lpcIncreaseOn = false;
	private float lpcSkillActiveTime = 50; 
	private float lpcSkillCoolTime = 50;

	private float lpsIncrement = 2.0f;
	private bool lpsIncreaseOn = false;
	private float lpsSkillActiveTime = 50; 
	private float lpsSkillCoolTime = 50; 

	private float loveIncrement = 300.0f;
	private bool loveIncreaseOn = false;
	private float loveSkillActiveTime = 1; 
	private float loveSkillCoolTime = 50;

	private loveCalc calc = new loveCalc();

    void Start () 
	{

	}
	void Update () 
	{
		if (lpcIncreaseOn == true)
		{
			canvas.skillLPCSlider.value += Time.deltaTime / lpcSkillActiveTime;

			if(canvas.skillLPCSlider.value == 1)
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
		}
		else if(lpcIncreaseOn == false)
		{
			if(canvas.skillLPCSlider.value != 0)
				canvas.skillLPCSlider.value -= Time.deltaTime / lpcSkillCoolTime;
			else
			{
				if(canvas.skillLPCBtn.interactable == false)
					canvas.skillLPCBtn.interactable = true;
			}
		}


		if (lpsIncreaseOn == true) 
		{
			canvas.skillLPSSlider.value += Time.deltaTime / lpsSkillActiveTime;

			if(canvas.skillLPSSlider.value == 1)
			{
				lpsIncreaseOn = false;
				canvas.lovePerSecond.setSkillOff ();
			}
		}
		else if (lpsIncreaseOn == false) 
		{
			if(canvas.skillLPSSlider.value != 0)
				canvas.skillLPSSlider.value -= Time.deltaTime / lpsSkillCoolTime;
			else
			{
				if(canvas.skillLPSBtn.interactable == false)
					canvas.skillLPSBtn.interactable = true;
			}
		}

		if (loveIncreaseOn == true) 
		{
			canvas.skillLoveSlider.value += Time.deltaTime / loveSkillActiveTime;

			if(canvas.skillLoveSlider.value == 1)
				loveIncreaseOn = false;
		}
		else if (loveIncreaseOn == false) 
		{
			if(canvas.skillLoveSlider.value != 0)
				canvas.skillLoveSlider.value -= Time.deltaTime / loveSkillCoolTime;
			else
			{
				if(canvas.skillLoveBtn.interactable == false)
					canvas.skillLoveBtn.interactable = true;
			}
		}
	}

	public void skillLPCIncrease()
	{
		lpcIncreaseOn = true;
		canvas.skillLPCBtn.interactable = false;
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
	}

	public void skillLPSIncrease()
	{
		lpsIncreaseOn = true;
		canvas.skillLPSBtn.interactable = false;
		canvas.lovePerSecond.setSkillOn (lpsIncrement);
	}

	public void skillLoveIncrease()
	{
		loveIncreaseOn = true;
		canvas.skillLoveBtn.interactable = false;
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
