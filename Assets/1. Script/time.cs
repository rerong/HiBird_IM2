using UnityEngine;
using System.Collections;

public class time : MonoBehaviour {

    public UnityEngine.UI.Slider _silder;
    public UnityEngine.UI.Button btn;
    public FlockController flockcontroller;

    private int maxBird = 25;

    [Range(-100f, 100f)]
    public float summonTime = 5 * 60 * 60;

    void Start()
    {
        btn.interactable = false;
    }

    void Update()
    {
        _silder.value += Time.deltaTime/summonTime;
        if (_silder.value == 1)
            btn.interactable = true;
    }

    public void clicked()
    {
        if (flockcontroller._childAmount < maxBird)
            flockcontroller._childAmount += 1;
        else
            
        _silder.value = 0;
        btn.interactable = false;

            
    }
}
