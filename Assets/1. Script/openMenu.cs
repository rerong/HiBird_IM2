using UnityEngine;
using System.Collections;

public class openMenu : MonoBehaviour {

    private float CameraRotationSpeed_y = 12;
	public canvasManager canvas;
    int count = 0;
    // Use this for initialization
    void Start()
    {
		canvas.menuPanel.gameObject.SetActive (false);
		canvas.closeMeunBtn.gameObject.SetActive (false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void clicked()
    {
		canvas.menuBtn.interactable = false;
        StartCoroutine(AutoTick());
    }
    private void animationCamera()
    {
        canvas.cameraRotate.transform.Rotate(CameraRotationSpeed_y / 100.0f, 0, 0);
    }
    IEnumerator AutoTick()
    {
        while (true)
        {
            if (count > 100)
            {
                count = 0;

				canvas.menuPanel.gameObject.SetActive (true);
                canvas.treePanel.gameObject.SetActive (true);
                canvas.loveShowBtn.gameObject.SetActive (false);
				canvas.closeMeunBtn.interactable = true;
				canvas.closeMeunBtn.gameObject.SetActive (true);
                canvas.mountainPanel.gameObject.SetActive (false);
                canvas.birdPanel.gameObject.SetActive (false);
                canvas.cashPanel.gameObject.SetActive (false);
                
                canvas.menuBtn.gameObject.SetActive (false);

                break;
            }
            count++;
            animationCamera();
            yield return new WaitForSeconds(0.01f);
        }
        
    }
}
