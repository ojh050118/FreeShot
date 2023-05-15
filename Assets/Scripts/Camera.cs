using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Camera MainCamera;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
            MainCamera.transform.position -= new Vector3(5, 0, 0);
        else if (Input.GetKey(KeyCode.D))
            MainCamera.transform.position += new Vector3(5, 0, 0);
        else if (Input.GetKey(KeyCode.W))
            MainCamera.transform.position += new Vector3(0, 0, 5);
        else if (Input.GetKey(KeyCode.S))
            MainCamera.transform.position -= new Vector3(0, 0, 5);
        else if (Input.GetKey(KeyCode.UpArrow))
            MainCamera.transform.position += new Vector3(0, 5, 0);
        else if (Input.GetKey(KeyCode.DownArrow))
            MainCamera.transform.position -= new Vector3(0, 5, 0);
    }
}
