using UnityEngine;
using System.Collections;

public class etcBtn : MonoBehaviour
{

    public canvasManager canvas;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetClicked()
    {
        canvas.goalPanel.gameObject.SetActive(false);
        canvas.setPanel.gameObject.SetActive(true);
      // canvas.goalBtn.interactable = false;
      //  canvas.setBtn.interactable = false;
        canvas.setBtn.gameObject.SetActive(false);
        canvas.goalBtn.gameObject.SetActive(false);
        canvas.etcCloseBtn.gameObject.SetActive(true);
    }

    public void GoalClicked()
    {
        canvas.goalPanel.gameObject.SetActive(true);
        canvas.setPanel.gameObject.SetActive(false);
        //   canvas.goalBtn.interactable = false;
        //   canvas.setBtn.interactable = false;
         canvas.setBtn.gameObject.SetActive(false);
        canvas.goalBtn.gameObject.SetActive(false);
        canvas.etcCloseBtn.gameObject.SetActive(true);
    }

    public void EtcCloseClicked()
    {
        canvas.goalPanel.gameObject.SetActive(false);
        canvas.setPanel.gameObject.SetActive(false);
        canvas.setBtn.gameObject.SetActive(true);
        canvas.goalBtn.gameObject.SetActive(true);
        canvas.etcCloseBtn.gameObject.SetActive(false);
    }
}
