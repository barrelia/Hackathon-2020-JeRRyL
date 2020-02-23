using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementScript : MonoBehaviour
{
    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;
    private int limitPitch = -50;
    private int limit2 = 60;

    // Update is called once per frame
    void Update()
    {
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");
        if (limitPitch <= pitch  && pitch <=  limit2) 
            {
            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
			}
    }
}
