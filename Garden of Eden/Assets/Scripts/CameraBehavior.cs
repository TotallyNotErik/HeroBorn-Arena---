using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{

	public Vector3 camOffset = new Vector3(0f, 10f, -5f);

	private Transform target;


    void Start()
    {
        target = GameObject.Find("CameraFocus").transform;

    }


    void LateUpdate()
    {
        this.transform.position = target.TransformPoint(camOffset);

	this.transform.LookAt(target);

    }
}
