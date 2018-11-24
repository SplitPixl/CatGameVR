using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceCamera : MonoBehaviour {

    public Transform sourceTransform;
    public Transform target;
    public Transform parent;

	// Use this for initialization
	void Start () {
		if (target == null) {
            target = GameObject.Find("/Head").transform;
        }
	}
	
	// Update is called once per frame
	void Update () {
        float x = parent.eulerAngles.x;
        float z = parent.eulerAngles.z;

        sourceTransform.LookAt(target);
        sourceTransform.eulerAngles = new Vector3(x, sourceTransform.eulerAngles.y + 180, z);
    }
}
