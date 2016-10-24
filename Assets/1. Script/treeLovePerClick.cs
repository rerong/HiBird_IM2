using UnityEngine;
using System.Collections;

public class treeLovePerClick : MonoBehaviour {
	public UnityEngine.UI.Text treeBuyMoney;
	public canvasManager canvas;
	public GameObject tree;

	private float cost = 2.0f;
    //현진 추가
    private float costView;
	private string costViewDanwe;

    private int level = 1;
	private float LPC = 1.0f;
	private float costRate = 1.07f;
	private float LPCRate = 1.02f;

// Use this for initialization
	void Start () {
	}

// Update is called once per frame
	void Update () 
	{
        //현진 추가
        costView = cost;
		costViewDanwe = "";

		if (costView / 1000 > 1) {
			costView = costView / 1000;
			costViewDanwe = "a";
			if(costView/1000 > 1){
				costView = costView/1000;
				costViewDanwe = "b";
				if(costView/1000 > 1){
					costView = costView/1000;
					costViewDanwe = "c";
					if (costView / 1000 > 1) {
						costView = costView / 1000;
						costViewDanwe = "d";
						if (costView / 1000 > 1) {
							costView = costView / 1000;
							costViewDanwe = "e";
						}
					}
				}
			}
		}

		treeBuyMoney.text = costView.ToString ("F2") + costViewDanwe + "\n" + level + "level";
	}

	public void treeUpgrade()
	{
		if (canvas.gameManaging.getLove() >= cost)
		{
			canvas.gameManaging.setLove (canvas.gameManaging.getLove() - cost);
			level += 1;
			if(level == 10 || level % 25 == 0)
				canvas.summonBird.setSummon ();

            //현진 추가
			tree.GetComponent<MeshRenderer> ().material.color = Color.Lerp (Color.gray,Color.white,level*0.0025f);

			if (level % 200 == 0) 
			{
				LPCRate += 0.01f;
				costRate += 0.01f;
			}

			LPC *= LPCRate;
			canvas.gameManaging.setLPC (LPC);
			cost *= costRate;

		}
	}
	public int getLevel()
	{
		return level;
	}
}
