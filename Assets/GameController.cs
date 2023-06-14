using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private  Cloth[] cloth;
    public GameObject connectorHair;
    [SerializeField] private HairScript hairScript;
    public GameObject scissors;

    // Start is called before the first frame update
    void Start()
    {
        cloth = FindObjectsOfType<Cloth>();
    }

    // Update is called once per frame
    void Update()
    {
        if (scissors.activeSelf)
        {
            // Debug.Log("scissors acre active");
            HairReact();
        } else {
            DisableCloth();
        }
    }

    

    public void HairReact()
    {
        connectorHair.SetActive(false);

        Debug.Log("Cloth are active");
        cloth = FindObjectsOfType<Cloth>();
        foreach (Cloth c in cloth)
        {
            c.enabled = true;            
        }

        hairScript.OnGravityEnebled();
    }

    public void DisableCloth()
    {
        Debug.Log("Cloth are inactive");

        cloth = FindObjectsOfType<Cloth>();
        foreach (Cloth c in cloth)
        {
            c.enabled = false;
        }
    }
}
