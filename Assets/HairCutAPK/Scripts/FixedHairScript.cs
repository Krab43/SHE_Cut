using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedHairScript : MonoBehaviour
{
    private Cloth _cloth;
    // Start is called before the first frame update
    void Start()
    {
        _cloth = GetComponent<Cloth>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            {
                OnClothDisabled();                
            }
    }

    public void OnClothEnabled()
    {
        _cloth.enabled = true;
    }

    public void OnClothDisabled()
    {
        _cloth.enabled = false;
    }
}
