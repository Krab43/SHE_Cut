using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ReplayCam
{
    public class ReplayCamera : MonoBehaviour
    {        
        // [SerializeField] private float min = 1f;
        // [SerializeField] private float max = 30f;
        // private float moveSpeed = 5f;
        // private Transform target;
        // private Camera cam;
        // private float rotationSpeed = 2f;
        // public float camSens = 500.0f;
        // float mouseSpeed = 3f;
        // float orbitDamping = 10f;
        // Vector3 localRot;
        // private Vector3 lastMouse = new Vector3(255, 255, 255);

        // private void Start() {
        //     GameObject headObj = GameObject.FindWithTag("Head");

        //     if (headObj != null)
        //     {
        //         target = headObj.transform;
        //     }

        //     cam = GetComponent<Camera>();
        // }
        
        // void Update() {
        //     cam.fieldOfView -= 5 * Input.GetAxis("Mouse ScrollWheel");
        //     cam.fieldOfView = Mathf.Clamp(cam.fieldOfView, min, max);

        //     lastMouse = Input.mousePosition - lastMouse;
            
        //     if (Input.GetMouseButton(1))
        //     {
        //         Debug.Log("Update");
        //         CamOrbit();
        //     }   

        //     lastMouse = Input.mousePosition - lastMouse;
        //     lastMouse = new Vector3(-lastMouse.y * camSens, lastMouse.x * camSens, 0);
        //     lastMouse = new Vector3(transform.eulerAngles.x + lastMouse.x, transform.eulerAngles.y + lastMouse.y, 0);
        //     if (Input.GetMouseButton(1))
        //         transform.eulerAngles = lastMouse;
        //     lastMouse = Input.mousePosition;
        // }

        // void CamOrbit()
        // {            
        //         Debug.Log("Enter OrbitCam");

        //         float mouseX = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
        //         float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;

        //         transform.Rotate(Vector3.right, mouseX, Space.World);
        //         transform.Rotate(Vector3.up, mouseY, Space.World);            
        // }

        // float mainSpeed = 10.0f; //regular speed
        // float shiftAdd = 50.0f; //multiplied by how long shift is held.  Basically running
        // float maxShift = 1000.0f; //Maximum speed when holdin gshift
        float camSens = 0.1f; //How sensitive it with mouse
        private Vector3 lastMouse = new Vector3(255, 255, 255); //kind of in the middle of the screen, rather than at the top (play)
        // private float totalRun = 1.0f;
        private Transform target;
        private Camera cam;
        [SerializeField] private float min = 1f;
        [SerializeField] private float max = 30f;
        private float rotationSpeed = 2f;


        private void Start() {
            GameObject headObj = GameObject.FindWithTag("Head");

            if (headObj != null)
            {
                target = headObj.transform;
            }

            cam = GetComponent<Camera>();
        }
        

        void Update()
        {
            cam.fieldOfView -= 5 * Input.GetAxis("Mouse ScrollWheel");
            cam.fieldOfView = Mathf.Clamp(cam.fieldOfView, min, max);

            lastMouse = Input.mousePosition - lastMouse;
            lastMouse = new Vector3(-lastMouse.y * camSens, lastMouse.x * camSens, 0);
            lastMouse = new Vector3(transform.eulerAngles.x + lastMouse.x, transform.eulerAngles.y + lastMouse.y, 0);
            if (Input.GetMouseButton(1))
            {
                // transform.eulerAngles = lastMouse;

                CamOrbit();
            }
            lastMouse = Input.mousePosition;
            //Mouse  camera angle done.  

            //Keyboard commands
            // Vector3 p = GetBaseInput();
            // if (p.sqrMagnitude > 0)
            // { // only move while a direction key is pressed
            //     if (Input.GetKey(KeyCode.LeftShift))
            //     {
            //         totalRun += 0.0166f;
            //         p = p * totalRun * shiftAdd;
            //         p.x = Mathf.Clamp(p.x, -maxShift, maxShift);
            //         p.y = Mathf.Clamp(p.y, -maxShift, maxShift);
            //         p.z = Mathf.Clamp(p.z, -maxShift, maxShift);
            //     }
            //     else
            //     {
            //         totalRun = Mathf.Clamp(totalRun * 0.5f, 1f, 1000f);
            //         p = p * mainSpeed;
            //     }

            //     p = p * 0.0166f;
            //     Vector3 newPosition = transform.position;
            //     if (Input.GetKey(KeyCode.Space))
            //     { //If player wants to move on X and Z axis only
            //         transform.Translate(p);
            //         newPosition.x = transform.position.x;
            //         newPosition.z = transform.position.z;
            //         transform.position = newPosition;
            //     }
            //     else
            //     {
            //         transform.Translate(p);
            //     }
            // }
        }

        void CamOrbit()
        {            
                Debug.Log("Enter OrbitCam");

                float mouseX = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
                float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;

                transform.Rotate(Vector3.right, mouseX, Space.World);
                transform.Rotate(Vector3.up, mouseY, Space.World);            
        }

        private Vector3 GetBaseInput()
        { //returns the basic values, if it's 0 than it's not active.
            Vector3 p_Velocity = new Vector3();
            if (Input.GetKey(KeyCode.W))
            {
                p_Velocity += new Vector3(0, 0, 1);
            }
            if (Input.GetKey(KeyCode.S))
            {
                p_Velocity += new Vector3(0, 0, -1);
            }
            if (Input.GetKey(KeyCode.A))
            {
                p_Velocity += new Vector3(-1, 0, 0);
            }
            if (Input.GetKey(KeyCode.D))
            {
                p_Velocity += new Vector3(1, 0, 0);
            }
            if (Input.GetKey(KeyCode.Q))
            {
                p_Velocity += Vector3.down;
            }
            if (Input.GetKey(KeyCode.E))
            {
                p_Velocity += Vector3.up;
            }
            return p_Velocity;
        }
    }
}