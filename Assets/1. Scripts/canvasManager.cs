using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class canvasManager : MonoBehaviour {

	public FlockController flockcontroller;
	public gameManager gameManaging;
	public summonBirds summonBird;
	public GameObject cameraRotate;

	public Button treeMenuBtn;
	public Button mountainMeunBtn;
	public Button birdMenuBtn;
	public Button cashMenuBtn;

	public Text loveDisplay;
	public Text lpcDisplay;
	public Text lpsDisplay;
	public Text cashDisplay;
	public Text birdDisplay;

    /*add*/
    public GameObject explainPanel;
    public Text explanationOfBirdDisplay;
    public Text nameOfBirdDisplay;
    public Text totalQuntityDisplay;
    public Text nowQuntityDisplay;
    /*for here*/

    public Button menuBtn;

	public GameObject normalPanel;
	public GameObject rarePanel;
	public GameObject uniquePanel;

	public Button treeUpgradBtn;
	public Button moutain1UpgradeBtn;
	public Button moutain2UpgradeBtn;
	public Button moutain3UpgradeBtn;
	public Button moutain4UpgradeBtn;
	public Button birdTimeSummonBtn;
	public Button birdSummonBtn;
	public Button normalBtn;
	public Button rareBtn;
	public Button uniqueBtn;

	public GameObject menuPanel;
	public GameObject treePanel;
	public GameObject mountainPanel;
	public GameObject birdPanel;
	public GameObject cashPanel;

    public Slider summonBirdSilder;

    public Material level0;
    public Material level1;
    public Material level2;
}
