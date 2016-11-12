using UnityEngine;
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
    public Material groundMaterial1;
    public Material groundMaterial2;
    public Material groundMaterial3;

    void Start() 
	{
		if (objUnit == 64)
			unitStr = null;
		else 
		{
			calc.firstChangeCalc (cost, objUnit);
			unitStr = calc.returnChangeUnit ();
		}

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
