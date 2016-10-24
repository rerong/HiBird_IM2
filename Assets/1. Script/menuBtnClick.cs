using UnityEngine;
using System.Collections;

public class menuBtnClick : MonoBehaviour {

	public GameObject btn;
	public canvasManager canvas;

	public void Start()
	{
	}

	public void Clicked()
	{

		if (btn.name.Contains("tree"))
		{
			canvas.treePanel.SetActive (true);
			canvas.mountainPanel.SetActive (false);
			canvas.birdPanel.SetActive (false);
			canvas.cashPanel.SetActive (false);
		}
		else if (btn.name.Contains("mountain"))
		{
			canvas.treePanel.SetActive (false);
			canvas.mountainPanel.SetActive (true);
			canvas.birdPanel.SetActive (false);
			canvas.cashPanel.SetActive (false);
		}
		else if (btn.name.Contains("bird"))
		{
			canvas.treePanel.SetActive (false);
			canvas.mountainPanel.SetActive (false);
			canvas.birdPanel.SetActive (true);
			canvas.cashPanel.SetActive (false);
		}
		else if (btn.name.Contains("cash"))
		{
			canvas.treePanel.SetActive (false);
			canvas.mountainPanel.SetActive (false);
			canvas.birdPanel.SetActive (false);
			canvas.cashPanel.SetActive (true);
		}


	}
}
