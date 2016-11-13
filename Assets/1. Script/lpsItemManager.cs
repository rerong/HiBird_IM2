﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class lpsItemManager : MonoBehaviour 
{
	public canvasManager canvas;
	public UnityEngine.UI.Text lpsBuyMoney;
	public float cost;
	public float objLPS;
	public int objUnit;
	private string unitStr;
	private int level = 0;
	private loveCalc calc = new loveCalc();

    //현진 추가
    public GameObject ground;
    public GameObject or;

    private Vector3 origin;
    private Vector3 trans;

    void Start() 
	{
		if (objUnit == 64)
			unitStr = null;
		else 
		{
			calc.firstChangeCalc (cost, objUnit);
			unitStr = calc.returnChangeUnit ();
		}

        // 현진 추가
        origin = ground.transform.position;
        trans = or.transform.position;
    }

	void Update() 
	{
		if (calc.changeCalcLove (cost, objUnit)) 
		{
			cost = calc.returnChangeCost ();
			objUnit = calc.returnChangeNumUnit ();
			unitStr = calc.returnChangeUnit ();
		}

		lpsBuyMoney.text = cost.ToString ("F2") + unitStr + "\n" + level + "level\n";
	}

	public void purchasedItem() 
	{

		if (calc.compareCalc(canvas.gameManaging.getLove(), canvas.gameManaging.getLoveUnit(), cost, objUnit))
		{
			canvas.gameManaging.setLove (calc.returnChangeCost(), calc.returnChangeNumUnit(), calc.returnChangeUnit());
			level += 1;
			objLPS = objLPS * 1.07f;
			cost *= 1.04f;
		}

		if (calc.changeCalcLove (cost, objUnit)) 
		{
			cost = calc.returnChangeCost ();
			objUnit = calc.returnChangeNumUnit ();
			unitStr = calc.returnChangeUnit ();
		}

        // 현진 추가
        if (origin == trans)
        {
            if (level <= 200)
                ground.GetComponent<MeshRenderer>().material.color = Color.Lerp(canvas.level0.color, canvas.level1.color, (level * 0.005f));
            else if (level < 400 && level > 200)
                ground.GetComponent<MeshRenderer>().material.color = Color.Lerp(canvas.level1.color, canvas.level2.color, (level - 200) * 0.005f);
        }
        else
        {
            if (level <= 50)
                ground.transform.position = Vector3.Lerp(origin, trans, level * 0.02f);
            else if (level <= 250 && level > 50)
                ground.GetComponent<MeshRenderer>().material.color = Color.Lerp(canvas.level0.color, canvas.level1.color, (level - 50) * 0.005f);
            else if (level < 450 && level > 250)
                ground.GetComponent<MeshRenderer>().material.color = Color.Lerp(canvas.level1.color, canvas.level2.color, (level - 250) * 0.005f);
        }
    }
	public int getLevel()
	{
		return level;
	}
}
