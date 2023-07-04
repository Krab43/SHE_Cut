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

    private Cloth _cloth;

    private Rigidbody _rb;

    // [SerializeField] private ScissorsScript scissorsScript;

    private Vector3 _fallDir;

    private Rigidbody _hairRigidbody;

    private void Awake() {
        _cloth = GetComponent<Cloth>();
    }

    void Start()
    {
        initialScale = hairObj.transform.localScale;
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {              
        CalcHairDist(); 
        // CalcSoftHairDist();  

        // if (Input.GetKeyDown(KeyCode.R))
        //     {
        //         OnClothDisabled();                
        //     } 

        // OnHairFalls();    
    }

    // public void OnClothDisabled()
    // {
    //     _cloth.enabled = false;
    // }

    void OnHairFalls()
    {
        if (isMain != true )
            _fallDir = Vector3.down * 0.5f * Time.deltaTime;        
    }

    public void OnClothEnabled()
    {
        Debug.Log("Cloth");
        if (_cloth != null)
        {
            _cloth.enabled = true;
        }
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

    public void OnGravityEnebled()
    {
        if (hairObj != null)
        {
            _hairRigidbody = hairObj.GetComponent<Rigidbody>();
            if (_hairRigidbody != null)
            {
                _hairRigidbody.useGravity = true;
            }
        }
    }    
}
