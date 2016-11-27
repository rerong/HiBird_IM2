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
	private float costRate = 1.07f;
	private float LPCRate = 1.02f;

	private loveCalc calc = new loveCalc();
// Use this for initialization
	void Start () 
	{
		/*if (PlayerPrefs.HasKey ("cost"))
			cost = PlayerPrefs.GetFloat ("cost");
		if (PlayerPrefs.HasKey ("lpc"))
			lpc = PlayerPrefs.GetFloat ("lpc");
		if (PlayerPrefs.HasKey ("costRate"))
			costRate = PlayerPrefs.GetFloat ("costRate");
		if (PlayerPrefs.HasKey ("LPCRate"))
			LPCRate = PlayerPrefs.GetFloat ("LPCRate");
		if (PlayerPrefs.HasKey ("unit"))
			unit = PlayerPrefs.GetInt ("unit");
		if (PlayerPrefs.HasKey ("lpcUnit"))
			lpcUnit = PlayerPrefs.GetInt ("lpcUnit");
		if (PlayerPrefs.HasKey ("level")) 
		{
			level = PlayerPrefs.GetInt ("level");
			canvas.gameManaging.setTreeLevel (level);
		}
		if (PlayerPrefs.HasKey ("unitStr"))
			unitStr = PlayerPrefs.GetString ("unitStr");
		if (PlayerPrefs.HasKey ("lpcUnitStr"))
			lpcUnitStr = PlayerPrefs.GetString ("lpcUnitStr");*/
		
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
		treeBuyMoney.text = cost.ToString ("F2") + unitStr + "\n" + level + "level";

		/*PlayerPrefs.SetFloat ("cost", cost);
		PlayerPrefs.SetFloat ("lpc", lpc);
		PlayerPrefs.SetInt ("unit" , unit);
		PlayerPrefs.SetInt ("lpcUnit" , lpcUnit);
		PlayerPrefs.SetString ("unitStr", unitStr);
		PlayerPrefs.SetString ("lpcUnitStr", lpcUnitStr);*/

	}

	public void treeUpgrade()
	{		
		if (calc.compareCalc(canvas.gameManaging.getLove(), canvas.gameManaging.getLoveUnit(), cost, unit))
		{
			canvas.gameManaging.setLove (calc.returnChangeCost(), calc.returnChangeNumUnit(), calc.returnChangeUnit());
			level += 1;
			//PlayerPrefs.SetInt ("level" , level);
			canvas.gameManaging.setTreeLevel (level);

			if(level == 10 || level % 25 == 0)
				canvas.summonBird.setSummon ();

			tree.GetComponent<MeshRenderer> ().material.color = Color.Lerp (Color.gray,Color.white,level*0.0025f); //현진 추가

			if (level % 200 == 0) 
			{
				LPCRate += 0.01f;
				costRate += 0.01f;

				//PlayerPrefs.SetFloat ("costRate", costRate);
				//PlayerPrefs.SetFloat ("LPCRate", LPCRate);
			}

			float lpc = canvas.gameManaging.getLPC ();
			int lpcUnit = canvas.gameManaging.getLPCUnit ();
			lpc *= LPCRate;

			canvas.gameManaging.setLPC (lpc, lpcUnit);
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
