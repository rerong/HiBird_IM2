using UnityEngine;
using System.Collections;

public class openClick : MonoBehaviour {

	public GameObject menuPanel;
	public GameObject detailTreePanel;
	public GameObject detailEarthPanel;
	public GameObject detailBirdsPanel;
	public GameObject detailCashPanel;
	bool isOpen = false;
// Use this for initialization
	void Start () {
		menuPanel.gameObject.SetActive (isOpen);
	}

// Update is called once per frame
	void Update () {

	}

	public void Clicked() {
		isOpen = !isOpen;
		menuPanel.gameObject.SetActive (isOpen);
		detailTreePanel.gameObject.SetActive (isOpen);
		detailEarthPanel.gameObject.SetActive (false);
		detailBirdsPanel.gameObject.SetActive (false);
		detailCashPanel.gameObject.SetActive (false);
	}
}
