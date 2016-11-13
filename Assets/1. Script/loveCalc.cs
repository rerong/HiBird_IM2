using UnityEngine;
using System.Collections;

public class loveCalc : MonoBehaviour 
{
	private float calcCost = 0.0f;
	private int calcUnit = 64;

	public bool changeCalcLove(float cost, int unit)
	{
		if(cost >= 1000)
		{
			cost /= 1000;
			unit++;

			calcCost = cost;
			calcUnit = unit;
			return true;
		}
		else
			return false;
	}

	public void firstChangeCalc(float cost, int unit)
	{
		calcCost = cost;
		calcUnit = unit;
	}

	public string returnChangeUnit()
	{
		string returnUnit;

		if (calcUnit > 90)
			returnUnit = ((char)(((calcUnit - 91) / 26) + 65)).ToString () + ((char)(((calcUnit - 91) % 26) + 65)).ToString ();
		else
			returnUnit = (calcUnit == 64) ? null : ((char)calcUnit).ToString ();

		return returnUnit;
	}

	public int returnChangeNumUnit()
	{
		return calcUnit;
	}

	public float returnChangeCost()
	{
		return calcCost;
	}

	public bool compareCalc(float costFirst, int unitFirst, float costSecond, int unitSecond)
	{
		calcCost = 0;
		calcUnit = 0;
		if(unitFirst < unitSecond)
			return false;
		else
		{
			int costUnitChange = unitFirst - unitSecond;
			costFirst = costFirst * Mathf.Pow(1000.0f, costUnitChange);
			if(costFirst < costSecond)
				return false;
			else
			{
				costFirst -= costSecond;
				unitFirst = unitSecond;
				int upscaleLoveUnit = 0;
				while(true)
				{
					if(costFirst < 1000)
						break;

					costFirst /= 1000;
					upscaleLoveUnit++;
				}
				unitFirst += upscaleLoveUnit;
				calcUnit = unitFirst;
				calcCost = costFirst;
			}
		}
		return true;
	}

	public void addCalc(float costFirst, int unitFirst, float costSecond, int unitSecond)
	{
		calcCost = 0;
		calcUnit = 0;

		if (unitFirst == unitSecond)
		{
			calcCost = costFirst + costSecond;
			calcUnit = unitFirst;
		}
		else 
		{
			if (unitFirst < unitSecond) 
			{
				int costUnitChange = unitFirst - unitSecond;
				costFirst = costFirst * Mathf.Pow (1000.0f, costUnitChange);
				calcCost = costFirst + costSecond;
				calcUnit = unitSecond;
			} 
			else 
			{
				int costUnitChange = unitSecond - unitFirst;
				costSecond = costSecond * Mathf.Pow (1000.0f, costUnitChange);
				calcCost = costFirst + costSecond;
				calcUnit = unitFirst;
			}
		}

		if (calcCost >= 1000) 
		{
			calcCost /= 1000;
			calcUnit++;
		}
			
	}
}
