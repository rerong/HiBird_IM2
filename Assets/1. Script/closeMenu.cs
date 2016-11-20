using UnityEngine;
using System.Collections;

public class closeMenu : MonoBehaviour {
	private float CameraRotationSpeed_y = -12;
	public canvasManager canvas;
    int count = 0;
// Use this for initialization
	void Start () {
	}

// Update is called once per frame
	void Update () 
	{

	}

	public void clicked()
	{
		canvas.closeMeunBtn.interactable = false;
		canvas.menuPanel.gameObject.SetActive (false);
		canvas.treePanel.gameObject.SetActive (false);
		canvas.loveShowBtn.gameObject.SetActive(true);
		canvas.mountainPanel.gameObject.SetActive (false);
		canvas.birdPanel.gameObject.SetActive (false);
		canvas.cashPanel.gameObject.SetActive (false);
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

				canvas.closeMeunBtn.gameObject.SetActive (false);
				canvas.menuBtn.gameObject.SetActive (true);
				canvas.menuBtn.interactable = true;

                break;
            }
            count++;
            animationCamera();
            yield return new WaitForSeconds(0.01f);
        }
        
    }
}
