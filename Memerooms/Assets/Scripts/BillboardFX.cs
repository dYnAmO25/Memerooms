using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillboardFX : MonoBehaviour
{
    public Transform camTransform;

    Quaternion originalRotation;

    Quaternion rot;

    void Start()
    {
        originalRotation = transform.rotation;
        camTransform = Camera.main.transform;
    }

    void Update()
    {
        rot = camTransform.rotation * originalRotation;

        transform.rotation = rot;
    }
}