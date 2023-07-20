using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPositionScript : MonoBehaviour
{
   [SerializeField] List<Quaternion> rotations;
    [SerializeField] int currentIndex = 0;

    private void Start() {
        if (rotations.Count > 0)
        {
            rotations[0] = transform.rotation;
        }
    }


    public void OnButtonClick()
    {
        currentIndex++;
        transform.rotation = rotations[currentIndex];
    }
}
