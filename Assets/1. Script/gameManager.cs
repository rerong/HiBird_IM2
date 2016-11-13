
using UnityEngine;
using System.Collections;

public class gameManager : MonoBehaviour 
{
	public canvasManager canvas;
	private float love = 980.0f;
    private float lovePerClick = 1.0f;
	private float lovePerSec = 1.0f;
	private int loveUnit = 64;
	private string loveUnitStr = null;
	private int lpcUnit = 64;
	private string lpcUnitStr = null;
	private int lpsUnit = 64;
	private string lpsUnitStr = null;
	private int treeLevel;

	private loveCalc calc = new loveCalc();

	void Start () 
	{
		treeLevel = 0;
	}

// Update is called once per frame
	void Update () {

		if (calc.changeCalcLove (love, loveUnit)) 
		{
			love = calc.returnChangeCost ();
			loveUnit = calc.returnChangeNumUnit ();
			loveUnitStr = calc.returnChangeUnit ();
		}

		canvas.loveDisplay.text = love.ToString ("F2") + loveUnitStr;
		canvas.lpcDisplay.text = lovePerClick.ToString("F2") + lpcUnitStr;
		canvas.birdDisplay.text = canvas.flockcontroller._childAmount + " / " + "25";
		canvas.lpsDisplay.text = lovePerSec.ToString ("F2") + lpsUnitStr;
	}

	public void Clicked() {
		calc.addCalc (love, loveUnit, lovePerClick, lpcUnit);
		love = calc.returnChangeCost ();
		loveUnit = calc.returnChangeNumUnit ();
		loveUnitStr = calc.returnChangeUnit ();
	}

	public float getLove()
	{
		return love;
	}

	public int getLoveUnit()
	{
		return loveUnit;
	}

	public float getLPC()
	{
		return lovePerClick;
	}

	public float getLPS()
	{
		return lovePerSec;
	}

	public int getTreeLevel()
	{
		return treeLevel;
	}

	public void setLove(float _love, int _unit, string _unitStr)
	{
		this.love = _love;
		this.loveUnit = _unit;
		this.loveUnitStr = _unitStr;
	}

	public void setLPC(float _lpc, int _lpcUnit, string _lpcUnitStr)
	{
		this.lovePerClick = _lpc;
		this.lpcUnit = _lpcUnit;
		this.lpcUnitStr = _lpcUnitStr;
	}

	public void setLPS(float _lps, int _lpsUnit, string _lpsUnitStr)
	{
		this.lovePerSec = _lps;
		this.lpsUnit = _lpsUnit;
		this.lpsUnitStr = _lpsUnitStr;
	}

	public void setTreeLevel(int _treeLevel)
	{
		this.treeLevel = _treeLevel;
	}
}
