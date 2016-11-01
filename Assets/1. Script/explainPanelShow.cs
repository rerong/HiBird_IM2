using UnityEngine;
using System.Collections;

public class explainPanelShow : MonoBehaviour {

    public canvasManager canvas;
    public GameObject btn;
    public GameObject thisBird;
    public UnityEngine.UI.Text nameOfBird;
    public UnityEngine.UI.Text explanationOfBird;
    public int quntityNow = 0;
    public int totalQuntity;
    public GameObject[] total;

    void Start () {

        canvas.explainPanel.SetActive(false);
        total = GameObject.FindGameObjectsWithTag(thisBird.tag);
        totalQuntity = total.Length;
        canvas.totalQuntityDisplay.text = totalQuntity.ToString();

        for (int i = 0; i <= totalQuntity; i++)
        {

            if (total[i].activeSelf == true)
            {
                quntityNow += 1;
            }
        }
        
    }

    public void Clicked()
    {

        if (btn.name.Contains("Bird"))
        {
            canvas.nameOfBirdDisplay.text = nameOfBird.text;
            canvas.explanationOfBirdDisplay.text = explanationOfBird.text;
            canvas.explainPanel.SetActive(true);

        }
        else if (btn.name.Contains("x"))
        {
            canvas.explainPanel.SetActive(false);
        }
        else if (btn.name.Contains("up"))
        {
            if (quntityNow < totalQuntity)
            {
                quntityNow += 1;
                canvas.nowQuntityDisplay.text = quntityNow.ToString();
            }
        }
        else if (btn.name.Contains("down"))
        {
            if (quntityNow > 0)
            {
                quntityNow -= 1;
                canvas.nowQuntityDisplay.text = quntityNow.ToString();
            }
        }


    }

}
