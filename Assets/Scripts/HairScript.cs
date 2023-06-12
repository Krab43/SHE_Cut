using UnityEngine;

public class HairScript : MonoBehaviour

{
    public GameObject hairObj;
    // public GameObject softHairObj;

    public GameObject headPoint;
    // public GameObject softHairPoint;
    public GameObject combPoint;

    Vector3 initialScale;
    // Vector3 softInitialScale;

    public bool isMain = true;

    void Start()
    {
        initialScale = hairObj.transform.localScale;
        // softInitialScale = softHairObj.transform.position;
    }

    void Update()
    {              
        CalcHairDist(); 
        // CalcSoftHairDist();       
    }

    void CalcHairDist()
    {
        Vector3 headPos = headPoint.transform.position;
        Vector3 combPos = combPoint.transform.position;

        // float distanceX = Mathf.Abs(headPos.x - combPos.x);
        // float distanceY = Mathf.Abs(headPos.y - combPos.y);
        float distanceZ = Mathf.Abs(headPos.z - combPos.z);

        Vector3 scale = initialScale;    
        scale.z = distanceZ; //+ distanceY/2 + distanceX*1.5f;
        hairObj.transform.localScale = scale;

        if (isMain)
        {
            Vector3 pos = hairObj.transform.position;
            pos.z = (headPos.z + combPos.z) / 2f;
            hairObj.transform.position = pos;

            hairObj.transform.LookAt(combPoint.transform);  
        }                    
    }

    // void CalcSoftHairDist()
    // {
        // Vector3 softHairPos = softHairPoint.transform.position;
        // Vector3 combPos = combPoint.transform.position;

        // float distance = Mathf.Abs(softHairPos.z - combPos.z);

        // Vector3 scale = softInitialScale;
        // scale.z = distance;
        // softHairObj.transform.localScale = scale;

        // Vector3 pos = softHairObj.transform.position;
        // pos.z = (softHairPos.z + combPos.z) / 2f;
        // softHairObj.transform.position = pos;
        
        // softHairObj.transform.LookAt(softHairPoint.transform);  
    // }
}
