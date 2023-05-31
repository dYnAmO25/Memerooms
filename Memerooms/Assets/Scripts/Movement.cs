using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] GameObject goCamera;
    [SerializeField] int iSpeed;
    [SerializeField] int iSense;

    private float fRotation;

    private CharacterController con;

    void Start()
    {
        con = GetComponent<CharacterController>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        //Vector3 v3Direction = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 v3Direction = transform.right * x + transform.forward * z;

        v3Direction.Normalize();
        v3Direction = v3Direction * iSpeed * Time.deltaTime;

        con.Move(v3Direction);


        fRotation = Input.GetAxisRaw("Mouse X") * Time.deltaTime * iSense;

        //transform.rotation = Quaternion.Euler(new Vector3(0 , fRotation, 0));

        transform.Rotate(new Vector3(0, fRotation, 0));
    }
}
