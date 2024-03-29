using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZhex1991.EZSoftBone;

namespace ReplayExmpleScripts
{
public class BoneStrandScript : MonoBehaviour
{
    public GameObject strand;
    public GameObject startPos;
    public GameObject endPos;
    // public GameObject comb;

    // private Rigidbody _rb;

    private Vector3 _initialScale;
    // public EZSoftBone ezSoftBoneScript;

    // Start is called before the first frame update
    private void Start() {
        _initialScale = strand.transform.localScale;
        // _rb = GetComponent<Rigidbody>();
        // _ezSoftBoneScript = GetComponent<EZSoftBone>();
    }

    // Update is called once per frame
    void Update()
    {
        CalcStrandDist();
        // if (Input.GetKey(KeyCode.R))
        // {
        //     if (ezSoftBoneScript != null)
        //     {
        //         Debug.Log("disable Hair physics");
        //         ezSoftBoneScript.enabled = false;
        //     }
        // }
    }

    void CalcStrandDist()
    {
        Vector3 hairStartPos = startPos.transform.position;
        Vector3 hairEndPos = endPos.transform.position;

        float strandSistZ = Mathf.Abs(hairStartPos.z - hairEndPos.z);

        Vector3 scale = _initialScale;

        scale.z = strandSistZ;

        strand.transform.localScale = scale;

        Vector3 pos = strand.transform.position;
        pos.z = (hairStartPos.z + hairEndPos.z) / 2;
        strand.transform.position = pos;

        strand.transform.LookAt(hairEndPos);
    }   

    // public void OnFixedHairReleased()
    // {
    //     if (ezSoftBoneScript != null)
    //     {
    //         Debug.Log("HairFalls");
    //         ezSoftBoneScript.enabled = true;
    //     }
    //         // ezSoftBoneScript.gameObject.activeSelf = true;
    //         // ezSoftBoneScript.gameObject.SetActive(true);
        

    //     // if (_ezSoftBoneScript != null)
    //     // {
    //     //     Debug.Log("HairFalls");
    //     //     _ezSoftBoneScript.enabled = true;
    //     // }
    //     // else
    //     // {
    //     //     Debug.LogError("EzSoftBoneScript is not assigned!");
    //     // }
    // } 
}
}
