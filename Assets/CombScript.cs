using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Replay;

namespace ReplayExmpleScripts
{
public class CombScript : MonoBehaviour
    {
        [SerializeField] private bool _isCombMoving; 
        private ReplayManager replay; 
        private Vector3 _startPos;
        public Transform endPos;
        private float progress = 0;
        public float speed = 2f;  
        // public GameObject scissors;
        // [SerializeField] private GameObject hairConnector;
        public ScissorsScript scissorsScript;

        // Start is called before the first frame update
        void Start()
        {
            replay = FindObjectOfType<ReplayManager>();
            _isCombMoving = true;
            _startPos = transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            if (!replay.ReplayMode())
            {
                Invoke(nameof(CombMovement), 1f);
                if (!_isCombMoving)
                {
                    // Invoke(nameof(PlayScissorsAnimation), 0.1f);
                    PlayScissorsAnimation();
                    _isCombMoving = true;
                }
            }   
            
            // if (Input.GetKeyDown(KeyCode.R) && !replay.ReplayMode())
            // {                
            //     scissorsScript.OnScissorsDeActive();            
            // }     
        }

        void CombMovement()
        {
            if (!replay.ReplayMode())
            {
                progress += speed * Time.deltaTime;
                transform.position = Vector3.Lerp(_startPos, endPos.transform.position, progress);

                if (progress >= 1f)
                {
                    _isCombMoving = false;
                }
            }
        }

        void PlayScissorsAnimation(){
            if (!replay.ReplayMode())
            {
                if (!_isCombMoving)
                scissorsScript.OnScissorsActive();
            }

            // Invoke(nameof(OnClothDisabled), 0.1f);
        }

        void OnClothDisabled()
        {
            // _fixedHairScript.OnClothDisabled();
            // _softHairScript.OnGravityEnebled();
            // hairConnector.SetActive(false);
        }
    }
}
