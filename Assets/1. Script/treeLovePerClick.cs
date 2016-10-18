using UnityEngine;
using System.Collections;

public class treeLovePerClick : MonoBehaviour {
	public touchMain touch;
	public UnityEngine.UI.Text treeBuyMoney;
	public summonBirds summonBird;
	private float cost = 2.0f;
	private int level = 0;
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
		treeBuyMoney.text = cost.ToString ("F2") +"\n" + (level + 1) + "level";
	}

	public void treeUpgrade()
	{
		if (touch.getLove() >= cost)
		{
			touch.setLove (touch.getLove() - cost);
			level += 1;
			summonBird.setClicked ();

			if (level % 200 == 0) 
			{
				LPCRate += 0.01f;
				costRate += 0.01f;
			}

			LPC *= LPCRate;
			touch.setLPC (LPC);
			cost *= costRate;

		}
	}
	public int getLevel()
	{
		return level;
	}
}
