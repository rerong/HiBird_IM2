using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour
{
    public int ro = 0;
    void Update()
    {
            transform.Rotate(5 * Time.deltaTime, 0, 0);
    }

    public void clicked()
    {

            transform.Rotate(1*Time.deltaTime, 0, 0);
    }
}
