using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class canvasManager : MonoBehaviour {

	public FlockController flockcontroller;
	public gameManager gameManaging;
	public summonBirds summonBird;
	public LovePerSec lovePerSecond;
	public GameObject cameraRotate;

    public Button treeMenuBtn;
	public Button mountainMeunBtn;
	public Button birdMenuBtn;
	public Button cashMenuBtn;

	public Text loveDisplay1;
    public Text loveDisplay2;
    public Text lpcDisplay;
	public Text lpsDisplay;
	public Text cashDisplay;
	public Text birdDisplay;

    public GameObject explainPanel;

    public Text explanationOfBirdDisplay;
    public Text nameOfBirdDisplay;
    public Image pictureOfBird;
    //  public Text totalQuntityDisplay;
    //  public Text nowQuntityDisplay;

    public Button loveShowBtn;

    public Button menuBtn;
	public GameObject normalPanel;
	public GameObject rarePanel;
	public GameObject uniquePanel;
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
	public Button closeMeunBtn;

    public Slider sumonBirdSilder;

    public Material level0;
    public Material level1;
    public Material level2;

    public Animator MenuBtnAni;
    public Animator CameraAni;
    public Animator HeartAni;

    public Button skillLPCBtn;
    public Button skillLPSBtn;
    public Button skillLoveBtn;
    public Button skillResetCoolBtn;
    public Button skillBirdCoolDownBtn;

    public Slider skillLPCSlider;
    public Slider skillLPSSlider;
    public Slider skillLoveSlider;
    public Slider skillResetCoolSlider;
    public Slider skillBirdCoolDownSlider;

    public GameObject setPanel;
    public GameObject goalPanel;
    public Button etcCloseBtn;
    public Button setBtn;
    public Button goalBtn;
}
