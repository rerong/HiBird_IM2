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

    //현진 추가
    public GameObject ground;
    public Material groundMaterial1;
    public Material groundMaterial2;
    public Material groundMaterial3;

    void Start() 
	{
		baseCost = cost;
	}

	void Update() {
		lpsBuyMoney.text = cost + "\n" + level + "level\n" + objLPS.ToString("F1") + "sec" ;
	}

	public void purchasedItem() 
	{
		if (canvas.gameManaging.getLove() >= cost)
		{
			canvas.gameManaging.setLove (canvas.gameManaging.getLove() - cost);
			level += 1;
			objLPS = objLPS * 1.2f;
			cost = Mathf.Round(baseCost + Mathf.Pow(level, 2f));

		}
        //현진 추가
        if(level <= 200)
            ground.GetComponent<MeshRenderer>().material.color = Color.Lerp(groundMaterial1.color, groundMaterial2.color, level * 0.005f);
        if (level < 400 && level > 200)
            ground.GetComponent<MeshRenderer>().material.color = Color.Lerp(groundMaterial2.color, groundMaterial3.color, (level-200) * 0.005f);
    }
	public int getLevel()
	{
		return level;
	}
}
