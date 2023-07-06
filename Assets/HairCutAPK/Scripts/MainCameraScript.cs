using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraScript : MonoBehaviour
{
    // private Camera cam;
    // [SerializeField] private float min = 1f;
    // [SerializeField] private float max = 30f;
    // [SerializeField] Transform _head;
    [SerializeField] float _mouseSpeed;
    // [SerializeField] float _orbitDamping;
    // Vector3 _localRoot;
    [SerializeField] Vector3   cameraRot;

    // Start is called before the first frame update
    void Start()
    {
        // cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        // cam.fieldOfView -= 5 * Input.GetAxis("Mouse ScrollWheel");
        // cam.fieldOfView = Mathf.Clamp(cam.fieldOfView, min, max);

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

    // public 
}
