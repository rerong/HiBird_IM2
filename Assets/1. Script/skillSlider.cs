using UnityEngine;
using System.Collections;

public class skillSlider : MonoBehaviour {

    public canvasManager canvas;

    public UnityEngine.UI.Slider slider;
    public UnityEngine.UI.Button button;

    private bool SkillOn = false;

    [Range(-100f, 100f)]
    public float skillTime;

    [Range(-100f, 100f)]
    public float skillCoolTime;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (button.interactable == false)
        {
            if (SkillOn == true)
            {
                slider.value += Time.deltaTime / skillTime;
                if (slider.value == 1)
                    SkillOn = false;
            }

            if (SkillOn == false)
            {
                slider.value -= Time.deltaTime / skillCoolTime;
                if (slider.value == 0)
                    button.interactable = true;
            }
        }
    }

    public void clicked()
    {
        button.interactable = false;
        SkillOn = true;
    }
}
