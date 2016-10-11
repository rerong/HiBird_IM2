using UnityEngine;
using System.Collections;

public class treeLovePerClick : MonoBehaviour {
	public touchMain touch;
	public UnityEngine.UI.Text treeBuyMoney;
	private float baseCost = 10.0f;
	private float cost = 10.0f;
	private int count = 0;
	private float touchPower = 1.0f;

	// Use this for initialization
	void Start () {
        Material mt = Resources.Load("level", typeof(Material)) as Material;
        Material mt2 = Resources.Load("level_2", typeof(Material)) as Material;

    }
	
	// Update is called once per frame
	void Update () 
	{
		treeBuyMoney.text = cost.ToString ("F0") +"\n" +count + "level";
    }

	public void treeUpgrade()
	{
		if (touch.getLove() >= cost)
		{
			touch.setLove (touch.getLove() - cost);
			count += 1;
			touch.setLPC(touch.getLPC() + touchPower);

			touchPower = Mathf.Round(Mathf.Pow(touchPower, 1.2f));
			cost = Mathf.Round(baseCost + Mathf.Pow(count, 2f));

		}
	}
}
