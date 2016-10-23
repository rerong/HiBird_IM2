using UnityEngine;
using System.Collections;

public class ColorBtnClick : MonoBehaviour {

	public canvasManager canvas;
	public GameObject btn;

    public void Start()
    {
		canvas.normalPanel.SetActive (true);
		canvas.rarePanel.SetActive (false);
		canvas.uniquePanel.SetActive (false);
    }

    public void Clicked()
    {

		if (btn.name.Contains("normal"))
        {
			canvas.normalPanel.SetActive (true);
			canvas.rarePanel.SetActive (false);
			canvas.uniquePanel.SetActive (false);
        }
		else if (btn.name.Contains("rare"))
        {
			canvas.normalPanel.SetActive (false);
			canvas.rarePanel.SetActive (true);
			canvas.uniquePanel.SetActive (false);
        }
		else if (btn.name.Contains("unique"))
        {
			canvas.normalPanel.SetActive (false);
			canvas.rarePanel.SetActive (false);
			canvas.uniquePanel.SetActive (true);
        }

    }
}
