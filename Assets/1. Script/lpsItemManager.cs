using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class lpsItemManager : MonoBehaviour 
{
	public canvasManager canvas;
	public UnityEngine.UI.Text lpsBuyMoney;
	public float cost;
	public float objLPS;
	private int level = 0;
	private float baseCost;
	private int unit = -1;
	private char unitChar = ' ';

    //현진 추가
    public GameObject ground;
    public Material groundMaterial1;
    public Material groundMaterial2;
    public Material groundMaterial3;

    void Start() 
	{
		baseCost = cost;
	}

	void Update() 
	{
		if(cost / 1000 > 1)
		{	
			cost /= 1000;
			unit = (unit == -1) ? 65 : unit + 1;
			unitChar = (char)unit;
		}

		lpsBuyMoney.text = cost.ToString ("F2") + unitChar + "\n" + level + "level\n";
	}

	public void purchasedItem() 
	{
		if (unit != -1)
			cost *= Mathf.Pow (1000, unit % 65 + 1);
		
		if (canvas.gameManaging.getLove() >= cost)
		{
			canvas.gameManaging.setLove (canvas.gameManaging.getLove() - cost);
			level += 1;
			objLPS = objLPS * 1.07f;
			cost *= 1.04f;

		}

		if (unit != -1)
			cost /= Mathf.Pow (1000, unit % 65 + 1);
		
        //현진 추가
        if(level <= 50)
            ground.GetComponent<MeshRenderer>().material.color 
			= Color.Lerp(groundMaterial1.color, groundMaterial2.color, level * 0.005f);
        else if (level < 100)
            ground.GetComponent<MeshRenderer>().material.color 
			= Color.Lerp(groundMaterial2.color, groundMaterial3.color, (level-200) * 0.005f);
    }
	public int getLevel()
	{
		return level;
	}
}
