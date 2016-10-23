using UnityEngine;
using System.Collections;

public class gameManager : MonoBehaviour 
{
	public canvasManager canvas;
	private float love = 1000000.0f;
	private float lovePerClick = 1.0f;
	private float lovePerSec = 1.0f;

	void Start () {
	}

// Update is called once per frame
	void Update () {
		canvas.loveDisplay.text = love.ToString("F0")+"\n";
		canvas.lpcDisplay.text = lovePerClick.ToString("F2") + "click\n";
		canvas.birdDisplay.text = canvas.flockcontroller._childAmount + " / " + "25";
	}

	public void Clicked() {
		love += lovePerClick;
	}

	public float getLove()
	{
		return love;
	}

	public float getLPC()
	{
		return lovePerClick;
	}

	public float getLPS()
	{
		return lovePerSec;
	}

	public void setLove(float love)
	{
		this.love = love;
	}

	public void setLPC(float lpc)
	{
		this.lovePerClick = lpc;
	}

	public void setLPS(float lps)
	{
		this.lovePerSec = lps;
	}
}
