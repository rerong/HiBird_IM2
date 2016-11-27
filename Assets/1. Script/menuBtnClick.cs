using UnityEngine;
using System.Collections;

public class menuBtnClick : MonoBehaviour {

	public GameObject btn;

    public Sprite change;
    public Sprite origin;
    public Sprite origin1;
    public Sprite origin2;

    public canvasManager canvas;

	public void Start()
	{
        canvas.treeMenuBtn.image.overrideSprite = change;
    }

	public void Clicked()
	{

		if (btn.name.Contains("tree"))
		{
            canvas.treeMenuBtn.image.overrideSprite = change;

            canvas.mountainMeunBtn.image.overrideSprite = origin;
            canvas.birdMenuBtn.image.overrideSprite = origin1;
            canvas.cashMenuBtn.image.overrideSprite = origin2;

            canvas.treePanel.SetActive (true);
			canvas.mountainPanel.SetActive (false);
			canvas.birdPanel.SetActive (false);
			canvas.cashPanel.SetActive (false);
		}
		else if (btn.name.Contains("mountain"))
		{
            canvas.mountainMeunBtn.image.overrideSprite = change;

            canvas.treeMenuBtn.image.overrideSprite = origin;
            canvas.birdMenuBtn.image.overrideSprite = origin1;
            canvas.cashMenuBtn.image.overrideSprite = origin2;

            canvas.treePanel.SetActive (false);
			canvas.mountainPanel.SetActive (true);
			canvas.birdPanel.SetActive (false);
			canvas.cashPanel.SetActive (false);
		}
		else if (btn.name.Contains("bird"))
		{
            canvas.birdMenuBtn.image.overrideSprite = change;

            canvas.treeMenuBtn.image.overrideSprite = origin;
            canvas.mountainMeunBtn.image.overrideSprite = origin1;
            canvas.cashMenuBtn.image.overrideSprite = origin2;

            canvas.treePanel.SetActive (false);
			canvas.mountainPanel.SetActive (false);
			canvas.birdPanel.SetActive (true);
			canvas.cashPanel.SetActive (false);
		}
		else if (btn.name.Contains("cash"))
		{
            canvas.cashMenuBtn.image.overrideSprite = change;

            canvas.treeMenuBtn.image.overrideSprite = origin;
            canvas.mountainMeunBtn.image.overrideSprite = origin1;
            canvas.birdMenuBtn.image.overrideSprite = origin2;

            canvas.treePanel.SetActive (false);
			canvas.mountainPanel.SetActive (false);
			canvas.birdPanel.SetActive (false);
			canvas.cashPanel.SetActive (true);
		}


	}
}
