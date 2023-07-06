using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Replay;

namespace ReplayExmpleScripts
{
public class GameManager : MonoBehaviour
{
    // public GameObject Comb;
    // public GameObject scissors;
    public List<GameObject> zones;
    private int currentIndex = 0;
    // private Vector3 _startPos;
    // public Transform endPos;
    // private float progress = 0;
    // public float speed = 2f;
    // [SerializeField] private bool _isCombMoving;    
    [SerializeField] private GameObject hairConnector;
    public ReplayManager replay;
    
    void Start()
    {
        // _startPos = Comb.transform.position;
        // _isCombMoving = true;
    }

    // Update is called once per frame
    void Update()
    {
        // if (!replay.ReplayMode())
        // {
        //     Invoke(nameof(CombMovement), 2f);
        //     if (!_isCombMoving)
        //     {
        //         Invoke(nameof(PlayScissorsAnimation), 0.5f);
        //         _isCombMoving = true;
        //     }
        // }        
    }

    // void CombMovement()
    // {
    //     progress += speed * Time.deltaTime;
    //     Comb.transform.position = Vector3.Lerp(_startPos, endPos.transform.position, progress);

    //     if (progress >= 1f)
    //     {
    //         _isCombMoving = false;
    //     }

    // }

    // void PlayScissorsAnimation(){
    //     if (_isCombMoving)
    //     scissors.SetActive(true);

    //     gameObject.SetActive(false);

    //     // Invoke(nameof(OnClothDisabled), 0.1f);
    // }

    // void OnClothDisabled()
    // {
    //     _fixedHairScript.OnClothDisabled();
    //     _softHairScript.OnGravityEnebled();
    //     hairConnector.SetActive(false);
    // }
    
    public void OnButtonClick()
    {
        if (zones.Count == 0)
        {
            Debug.Log("List is Empty");
            return;
        }

        if (currentIndex >= zones.Count)
        {
            Debug.Log("End of list");
            return;
        }

        // Deact prev obj
        if (currentIndex > 0)
        {
            zones[currentIndex - 1].SetActive(false); // TODO: active
        }

        // Act next obj
        zones[currentIndex].SetActive(true);

        currentIndex++;
    }
}
}
