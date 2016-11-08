using UnityEngine;
using System.Collections;

public class color : MonoBehaviour {

    /*public Shader shader1;
    public Shader shader2;
    public Renderer rend;*/

    //Material mt = Resources.Load("level", typeof(Material)) as Material;
    //Material mt2 = Resources.Load("level_2", typeof(Material)) as Material;

    //public Shader mt1;
    public Material mt2;

    public GameObject gameobject;

    // Use this for initialization
    void Start () {
        /*rend = GetComponent<Renderer>();*/
        //mt1 = Resources.Load("level", typeof(Shader)) as Shader;
        mt2 = Resources.Load("level", typeof(Material)) as Material;
    }
	
	// Update is called once per frame
	void Update () {

        /*if (Input.GetButtonDown("Jump"))
            if (rend.material.shader == shader1)
                rend.material.shader = shader2;
            else
                rend.material.shader = shader1;*/

        //gameobject.GetComponent<MeshRenderer>().material.shader = mt1;

        //gameobject.GetComponent<MeshRenderer>().material = mt;
    }

    public void clicked()
    {
        gameobject.GetComponent<MeshRenderer>().material = mt2;
        //gameobject.GetComponent<MeshRenderer>().material.shader = mt1;
    }
}
