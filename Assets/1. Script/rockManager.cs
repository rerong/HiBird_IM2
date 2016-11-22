using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class rockManager : MonoBehaviour 
{
	public canvasManager canvas;
	public UnityEngine.UI.Text lpsText;
	public float cost;
	public float objLPS;
	public int objUnit;
	public int unit;
	public int upgrade;
	public float objCostRate;
	private string unitStr;
	private int level = 0;
	private loveCalc calc = new loveCalc();
	private bool isShow;

    //현진 추가
    public GameObject rock;
    public GameObject rockHeightLimit;

    private Vector3 origin;
    private Vector3 trans;

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

        // 현진 추가
        origin = rock.transform.position;
        trans = rockHeightLimit.transform.position;
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
			lpsText.text = "tree level : " + upgrade;
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
				cost *= objCostRate;
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
            
            if (level <= 50)
                rock.transform.position = Vector3.Lerp(origin, trans, level * 0.02f);
            else if (level <= 450)
                rock.GetComponent<MeshRenderer>().material.color = Color.Lerp(canvas.level0.color, canvas.level2.color, (level - 50) * 0.0025f);
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
