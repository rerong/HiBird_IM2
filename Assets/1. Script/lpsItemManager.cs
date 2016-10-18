using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class lpsItemManager : MonoBehaviour 
{
	public UnityEngine.UI.Text lpsBuyMoney;
	public float cost;
	public float objLPS;
	private int level = 0;
	public touchMain touch;
	private float baseCost;

	void Start() {
		baseCost = cost;
	}

	void Update() {
		lpsBuyMoney.text = cost + "\n" + level + "level\n" + objLPS.ToString("F1") + "sec" ;
	}

	public void purchasedItem() 
	{
		if (touch.getLove() >= cost)
		{
			touch.setLove (touch.getLove() - cost);
			level += 1;
			objLPS = objLPS * 1.2f;
			cost = Mathf.Round(baseCost + Mathf.Pow(level, 2f));

		}
	}
	public int getLevel()
	{
		return level;
	}
}
