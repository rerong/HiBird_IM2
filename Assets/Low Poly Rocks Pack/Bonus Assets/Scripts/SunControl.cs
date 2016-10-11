using UnityEngine;
using System.Collections;

public class SunControl : MonoBehaviour {

	//Range for min/max values of variable
	[Range(-10f, 10f)]
	public float sunRotationSpeed_x, sunRotationSpeed_y;

    public UnityEngine.UI.Text UITEXT;
    public UnityEngine.UI.Text UITEXT2;
    public UnityEngine.UI.Text UITEXT3;

    // Sun Movement
    void Update () {

        //double x = gameObject.transform.rotation.x * (180.0 / Mathf.PI);
        double y = gameObject.transform.rotation.y * (180.0 / Mathf.PI);
        //double z = gameObject.transform.rotation.z * (180.0 / Mathf.PI);

        if (y > 42 || y < -25)
        {
            sunRotationSpeed_x = -sunRotationSpeed_x;
            sunRotationSpeed_y = -sunRotationSpeed_y;
        }
        gameObject.transform.Rotate(sunRotationSpeed_x * Time.deltaTime, sunRotationSpeed_y * Time.deltaTime, 0);

        /*
        UITEXT.text = x.ToString();
        UITEXT2.text = y.ToString();
        UITEXT3.text = z.ToString();*/
    }
}
