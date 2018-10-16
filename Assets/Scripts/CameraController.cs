using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform CameraTransform;
    private float y, z;

    void Start()
    {
        CameraTransform = GetComponent<Transform>();
    }

    void Update()
    {
        y = CameraTransform.position.y;
        z = CameraTransform.position.z;
        CameraTransform.position = new Vector3(0.0f, y, z);
    }
}
