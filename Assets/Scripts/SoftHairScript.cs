using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoftHairScript : MonoBehaviour
{
    private Rigidbody _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {      
        
    }

    public void OnGravityEnebled()
    {
        if (_rb != null)
        _rb.useGravity = true;
    }
}
