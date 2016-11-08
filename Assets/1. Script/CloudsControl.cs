using UnityEngine;
using System.Collections;

public class CloudsControl : MonoBehaviour {

	//Range for min/max values of variable
	[Range(-100f, 100f)]
	public float cloudsMoveSpeed_x, cloudsMoveSpeed_z;

	// Clouds Movement
	void Update () {
        
		gameObject.transform.Translate (cloudsMoveSpeed_x * Time.deltaTime, 0f, cloudsMoveSpeed_z * Time.deltaTime);
       /* if(gameObject.transform.position.x > 255)
            { gameObject.transform.Translate(-255, 0, 0); }*/
    }
}
