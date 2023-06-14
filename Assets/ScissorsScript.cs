using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ReplayExmpleScripts
{
public class ScissorsScript : MonoBehaviour
{

    // private  Cloth[] cloth;
    // private Cloth[] clothDis;

    // public GameObject connectorHair;

    // public bool active;

    // [SerializeField] private HairScript hairScript;
    public GameController gameController;

    private void Awake() {
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //   if(active)
        //   {
        //     Invoke(nameof(HairReact), 0.3f);
        //   }
        //   else
        //   {
        //     Invoke(nameof(DisableCloth), 0.3f);
        //   }
    }

    // public void OnClothDisabled()
    // {
    //     clothDis = FindObjectsOfType<Cloth>();
    //     foreach (Cloth c in clothDis)
    //     {
    //         Debug.Log("Cloth foreach disable");
    //         c.enabled = false;
    //     }
    // }

    // private void OnEnable()
    // {
    //     if (gameController != null)
    //         gameController.HairReact();

    // }

//     void HairReact()
//     {
//         connectorHair.SetActive(false);

//         cloth = FindObjectsOfType<Cloth>();
//         foreach (Cloth c in cloth)
//         {
//             c.enabled = true;            
//         }

//         hairScript.OnGravityEnebled();
//     }

//     void DisableCloth()
// {
//     cloth = FindObjectsOfType<Cloth>();
//     foreach (Cloth c in cloth)
//     {
//         c.enabled = false;
//     }

//     hairScript.OnGravityEnebled();
// }
}
}
