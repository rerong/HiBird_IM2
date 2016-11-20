using UnityEngine;
using System.Collections;

public class openClick : MonoBehaviour {
	public canvasManager canvas;
	private bool isOpen = false;
// Use this for initialization
	void Start () {
		canvas.menuPanel.gameObject.SetActive (isOpen);
	}

// Update is called once per frame
	void Update () {

	}

	public void Clicked() {
		isOpen = !isOpen;
		canvas.menuPanel.gameObject.SetActive (isOpen);
		canvas.treePanel.gameObject.SetActive (isOpen);
        canvas.loveShowBtn.gameObject.SetActive(!isOpen);
        canvas.mountainPanel.gameObject.SetActive (false);
		canvas.birdPanel.gameObject.SetActive (false);
		canvas.cashPanel.gameObject.SetActive (false);
	}
}
