using UnityEngine;
using System.Collections;

public class menuBtnClick : MonoBehaviour {

	public GameObject thisPanel;
	public GameObject otherPanel1;
	public GameObject otherPanel2;
	public GameObject otherPanel3;

	void Start () {
		thisPanel.gameObject.SetActive (false);
		otherPanel1.gameObject.SetActive (false);
		otherPanel2.gameObject.SetActive (false);
		otherPanel3.gameObject.SetActive (false);
	}

	void Update () {
	}

	public void Clicked() {
		thisPanel.gameObject.SetActive (true);
		otherPanel1.gameObject.SetActive (false);
		otherPanel2.gameObject.SetActive (false);
		otherPanel3.gameObject.SetActive (false);
	}
}
