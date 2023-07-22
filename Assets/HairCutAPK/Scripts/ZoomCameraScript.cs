using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.InputSystem;

public class ZoomCameraScript : MonoBehaviour
{
//    public float speed = 0.01f;
// 	private float prevMagnitude = 0;
// 	private int touchCount = 0;

	private Camera cam;
    [SerializeField] private float min = 1f;
    [SerializeField] private float max = 30f;

	private void Start () 
	{
		cam = GetComponent<Camera>();
	}

	private void Update() {
		cam.fieldOfView -= 5 * Input.GetAxis("Mouse ScrollWheel");
        cam.fieldOfView = Mathf.Clamp(cam.fieldOfView, min, max);
	}


	// private void CameraZoom(float increment) => Camera.main.fieldOfView = Mathf.Clamp(Camera.main.fieldOfView + increment, 20, 60);

}
