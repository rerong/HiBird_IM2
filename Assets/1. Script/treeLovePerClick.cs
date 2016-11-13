using UnityEngine;
using System.Collections;

public class treeLovePerClick : MonoBehaviour {
	public UnityEngine.UI.Text treeBuyMoney;
	public canvasManager canvas;
	public GameObject tree;

	private float cost = 2.0f;
	private int unit = 64;
	private string unitStr = null;
    private int level = 1;
	private float LPC = 1.0f;
	private int lpcUnit = 64;
	private string lpcUnitStr = null;
	private float costRate = 1.07f;
	private float LPCRate = 1.02f;

	private loveCalc calc = new loveCalc();
// Use this for initialization
	void Start () 
	{
	}

// Update is called once per frame
	void Update () 
	{
		if (calc.changeCalcLove (cost, unit)) 
		{
			cost = calc.returnChangeCost ();
			unit = calc.returnChangeNumUnit ();
			unitStr = calc.returnChangeUnit ();
		}
		canvas.gameManaging.setLPC (LPC, lpcUnit, lpcUnitStr);
		treeBuyMoney.text = cost.ToString ("F2") + unitStr + "\n" + level + "level";

	}

	public void treeUpgrade()
	{		
		if (calc.compareCalc(canvas.gameManaging.getLove(), canvas.gameManaging.getLoveUnit(), cost, unit))
		{
			canvas.gameManaging.setLove (calc.returnChangeCost(), calc.returnChangeNumUnit(), calc.returnChangeUnit());
			level += 1;
			canvas.gameManaging.setTreeLevel (level);

			if(level == 10 || level % 25 == 0)
				canvas.summonBird.setSummon ();

			tree.GetComponent<MeshRenderer> ().material.color = Color.Lerp (Color.gray,Color.white,level*0.0025f); //현진 추가

			if (level % 200 == 0) 
			{
				LPCRate += 0.01f;
				costRate += 0.01f;
			}

			LPC *= LPCRate;

			if (calc.changeCalcLove (LPC, lpcUnit)) 
			{
				LPC = calc.returnChangeCost ();
				lpcUnit = calc.returnChangeNumUnit ();
				lpcUnitStr = calc.returnChangeUnit ();
			}

			canvas.gameManaging.setLPC (LPC, lpcUnit, lpcUnitStr);
			cost *= costRate;

			if (calc.changeCalcLove (cost, unit)) 
			{
				cost = calc.returnChangeCost ();
				unit = calc.returnChangeNumUnit ();
				unitStr = calc.returnChangeUnit ();
			}
		}
	}
	public int getLevel()
	{
		return level;
	}
}
