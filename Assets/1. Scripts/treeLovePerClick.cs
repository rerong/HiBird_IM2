using UnityEngine;
using System.Collections;

public class treeLovePerClick : MonoBehaviour {
	public UnityEngine.UI.Text treeBuyMoney;
	public canvasManager canvas;
	public GameObject tree;

	private float cost = 2.0f;
    private int level = 1;
	private float LPC = 1.0f;
	private float costRate = 1.07f;
	private float LPCRate = 1.02f;
	private int unit = -1;
	private char unitChar = ' ';

// Use this for initialization
	void Start () 
	{
	}

// Update is called once per frame
	void Update () 
	{
		if(cost / 1000 > 1)
		{	
			cost /= 1000;
			unit = (unit == -1) ? 65 : unit + 1;
			unitChar = (char)unit;
		}

		treeBuyMoney.text = cost.ToString ("F2") + unitChar + "\n" + level + "level";
	}

	public void treeUpgrade()
	{
		if (unit != -1)
			cost *= Mathf.Pow (1000, unit % 65 + 1);
		
		if (canvas.gameManaging.getLove() >= cost)
		{
			canvas.gameManaging.setLove (canvas.gameManaging.getLove() - cost);
			level += 1;
			if(level == 10 || level % 25 == 0)
				canvas.summonBird.setSummon ();

			tree.GetComponent<MeshRenderer> ().material.color = Color.Lerp (Color.gray,Color.white,level*0.0025f); //현진 추가

			if (level % 200 == 0) 
			{
				LPCRate += 0.01f;
				costRate += 0.01f;
			}

			LPC *= LPCRate;
			canvas.gameManaging.setLPC (LPC);
			cost *= costRate;

		}

		if (unit != -1)
			cost /= Mathf.Pow (1000, unit % 65 + 1);
	}
	public int getLevel()
	{
		return level;
	}
}
