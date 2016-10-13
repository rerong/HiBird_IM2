using UnityEngine;
using System.Collections;

public class ColorBtnClick : MonoBehaviour {

    public GameObject Btn;
    public GameObject GrayPanel;
    public GameObject YellowPanel;
    public GameObject BluePanel;


    void Start()
    {
        GrayPanel.gameObject.SetActive(true);
        YellowPanel.gameObject.SetActive(false);
        BluePanel.gameObject.SetActive(false);
    }

    public void Clicked()
    {

        if (Btn.name.Contains("Gray"))
        {
            GrayPanel.gameObject.SetActive(true);
            YellowPanel.gameObject.SetActive(false);
            BluePanel.gameObject.SetActive(false);
        }
        else if (Btn.name.Contains("Yellow"))
        {
            GrayPanel.gameObject.SetActive(false);
            YellowPanel.gameObject.SetActive(true);
            BluePanel.gameObject.SetActive(false);
        }
        else if (Btn.name.Contains("Blue"))
        {
            GrayPanel.gameObject.SetActive(false);
            YellowPanel.gameObject.SetActive(false);
            BluePanel.gameObject.SetActive(true);
        }

    }
}
