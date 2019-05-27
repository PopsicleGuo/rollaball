using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour{

    public GameObject obj;

	// Use this for initialization
	void Start () {
        Debug.Log(obj.name);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            obj.transform.Translate(new Vector3(0, 0, 0.1f));
        }
        if (Input.GetKey(KeyCode.S))
        {
            obj.transform.Translate(new Vector3(0, 0, -0.1f));
        }
        if (Input.GetKey(KeyCode.A))
        {
            obj.transform.Translate(new Vector3(-0.1f, 0, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            obj.transform.Translate(new Vector3(0.1f, 0, 0));
        }
    }
}
