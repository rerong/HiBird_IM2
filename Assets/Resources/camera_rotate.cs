using UnityEngine;
using System.Collections;

public class camera_rotate : MonoBehaviour {

    private float CameraRotationSpeed_y = 12;
    public UnityEngine.GameObject gameobject;
    public UnityEngine.UI.Button button_rotate;
    int count = 0;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void clicked()
    {
        StartCoroutine(AutoTick());
    }
    private void animationCamera()
    {
        gameobject.transform.Rotate(CameraRotationSpeed_y / 100.0f, 0, 0);
    }
    IEnumerator AutoTick()
    {
        while (true)
        {
            if (count > 100)
            {
                count = 0;
                CameraRotationSpeed_y = -CameraRotationSpeed_y;
                button_rotate.interactable = true;
                break;
            }
            button_rotate.interactable = false;
            count++;
            animationCamera();
            yield return new WaitForSeconds(0.01f);
        }
    }
}
