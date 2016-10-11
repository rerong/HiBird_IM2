using UnityEngine;
using System.Collections;

public class time : MonoBehaviour {

    public UnityEngine.UI.Slider _silder;
    public UnityEngine.UI.Button btn;
    public FlockController flockcontroller;

    public int maxBird = 25;

    [Range(-100f, 100f)]
    public float a;

    void Start()
    {
        btn.interactable = false;
        btn.image.fillCenter = false;
    }

    void Update()
    {
        _silder.value += Time.deltaTime/a;
        if (_silder.value == 1)
        {
            btn.interactable = true;
        }
    }

    public void clicked()
    {
        if (flockcontroller._childAmount < maxBird)
        {
            flockcontroller._childAmount = flockcontroller._childAmount + 1;
        }
        _silder.value = 0;
        if(_silder.value == 0)
        { btn.interactable = false; }
    }
}
