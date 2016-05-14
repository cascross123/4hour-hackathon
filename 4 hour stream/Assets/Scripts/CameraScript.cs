using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

    public Transform squ;
    private Vector3 objectpos;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        objectpos = squ.transform.position;

        transform.position = new Vector3(objectpos.x, objectpos.y, transform.position.z);
	}
}
