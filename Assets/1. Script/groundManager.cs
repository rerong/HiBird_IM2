using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class groundManager : MonoBehaviour 
{
	public canvasManager canvas;
	public UnityEngine.UI.Text lpsText;
	public float cost;
	public float objLPS;
	public int objUnit;
	public int unit;
	private int upgrade = 50;
	private string unitStr;
	private int level = 0;
	private loveCalc calc = new loveCalc();
	private bool isShow;

    public GameObject ground;

    void Start() 
	{
		if (unit == 64)
			unitStr = null;
		else 
		{
			calc.firstChangeCalc (cost, unit);
			unitStr = calc.returnChangeUnit ();
		}
		isShow = false;
    }

	void Update() 
	{
		if (calc.changeCalcLove (cost, unit)) 
		{
			cost = calc.returnChangeCost ();
			unit = calc.returnChangeNumUnit ();
			unitStr = calc.returnChangeUnit ();
		}

		if (isShow)
			lpsText.text = cost.ToString ("F2") + unitStr + "\n" + (level + 1) + "level\n";
		else
            lpsText.text = "Tree Level\n" + upgrade + " Open";
    }

	public void purchasedItem() 
	{

		if (isShow)
		{
			if (calc.compareCalc(canvas.gameManaging.getLove(), canvas.gameManaging.getLoveUnit(), cost, unit))
			{
				canvas.gameManaging.setLove (calc.returnChangeCost(), calc.returnChangeNumUnit(), calc.returnChangeUnit());
				level += 1;
				objLPS = objLPS * 1.04f;
				cost *= 1.07f;
			}

			if (calc.changeCalcLove (cost, unit)) 
			{
				cost = calc.returnChangeCost ();
				unit = calc.returnChangeNumUnit ();
				unitStr = calc.returnChangeUnit ();
			}

			if (calc.changeCalcLove (objLPS, objUnit)) 
			{
				objLPS = calc.returnChangeCost ();
				objUnit = calc.returnChangeNumUnit ();
			}

            if (level <= 400)
            	ground.GetComponent<MeshRenderer>().material.color = Color.Lerp(canvas.level0.color, canvas.level1.color, (level * 0.0025f));
		} 
		
    }
	public int getLevel()
	{
		return level;
	}

	public bool getShow()
	{
		if (!isShow) 
		{
			if (canvas.gameManaging.getTreeLevel () > upgrade) 
			{
				isShow = true;
			}
		}

		return isShow;
	}

	public float getObjLPS()
	{
		return objLPS;
	}

	public int getObjUnit()
	{
		return objUnit;
	}
}
