using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoftHairScript : MonoBehaviour
{
   public GameObject hairObj;
    public GameObject hairPoint;
    public GameObject combPoint;

    private Vector3 initialScale;

    void Start()
    {
        initialScale = hairObj.transform.localScale;
    }

    void Update()
    {      
        Vector3 headPos = hairPoint.transform.position;
        Vector3 combPos = combPoint.transform.position;

        float distance = Mathf.Abs(headPos.z - combPos.z);

        Vector3 scale = initialScale;
        scale.z = distance;
        hairObj.transform.localScale = scale;

        Vector3 pos = hairObj.transform.position;
        pos.z = (headPos.z + combPos.z) / 2f;
        hairObj.transform.position = pos;
    }
}
