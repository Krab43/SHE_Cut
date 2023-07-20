using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraScript : MonoBehaviour
{  
    [SerializeField] float _mouseSpeed;  
       
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            CameraOrbit();
        }

    }

    void CameraOrbit()
    {
        if(Input.GetAxis("Mouse Y") != 0 || Input.GetAxis("Mouse X") != 0)
        {
            float verticalInput = Input.GetAxis("Mouse Y") * _mouseSpeed * Time.deltaTime;
                float horizontalInput = Input.GetAxis("Mouse X") * _mouseSpeed * Time.deltaTime;

                transform.Rotate(Vector3.right, verticalInput);
                transform.Rotate(Vector3.up, horizontalInput, Space.World);  
        }
    }
}
