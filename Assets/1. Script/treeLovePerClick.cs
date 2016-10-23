using UnityEngine;
using System.Collections;

public class treeLovePerClick : MonoBehaviour {
	public UnityEngine.UI.Text treeBuyMoney;
	public canvasManager canvas;
	private float cost = 2.0f;
	private int level = 1;
	private float LPC = 1.0f;
	private float costRate = 1.07f;
	private float LPCRate = 1.02f;

// Use this for initialization
	void Start () {
		Material mt = Resources.Load("level", typeof(Material)) as Material;
		Material mt2 = Resources.Load("level_2", typeof(Material)) as Material;
	}

// Update is called once per frame
	void Update () 
	{
		treeBuyMoney.text = cost.ToString ("F2") +"\n" + level + "level";
	}

	public void treeUpgrade()
	{
		if (canvas.gameManaging.getLove() >= cost)
		{
			canvas.gameManaging.setLove (canvas.gameManaging.getLove() - cost);
			level += 1;
			if(level == 10 || level % 25 == 0)
				canvas.summonBird.setSummon ();

			if (level % 200 == 0) 
			{
				LPCRate += 0.01f;
				costRate += 0.01f;
			}

			LPC *= LPCRate;
			canvas.gameManaging.setLPC (LPC);
			cost *= costRate;

		}
	}
	public int getLevel()
	{
		return level;
	}
}
