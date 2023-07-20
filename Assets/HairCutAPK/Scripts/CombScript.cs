using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Replay;

namespace ReplayExmpleScripts
{
public class CombScript : MonoBehaviour
    {
        private bool _isCombMoving; 
        private ReplayManager replay; 
        private Vector3 _startPos;
        public Transform endPos;
        private float progress = 0;
        public float speed = 2f;          
        public ScissorsScript scissorsScript;
        public DegreeViewScript degreeViewScript;

        public bool isFirstStrand;
        [SerializeField]bool degreeShowStart = false;
        [SerializeField]bool degreeShowed = false;
        public GameObject degreeView;
        public GameObject combMain;
        public GameObject scissors;
       
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
                //  Movement
                Invoke(nameof(CombMovement), 2f);

                if (!_isCombMoving)
                {
                    if (isFirstStrand)
                    {
                        Invoke(nameof(OnDegreeView), 0.5f);
                    }
                    else
                    {
                        DegreeShowTrue();
                    }

                    if (degreeShowed)
                    {
                        Invoke(nameof(OnScissorsAnimEnabled), 1f);
                    }
                }
            }              
        }

        void OnDegreeView()
        {
            if (!degreeShowStart)
            {
                degreeShowStart = true;
                degreeView.SetActive(true);
                combMain.SetActive(false);                
            }             
            if (degreeShowStart)
            {
                Invoke(nameof(OnDegreeViewEnds), 2f);
            }   
        }

        public void DegreeShowTrue()
        {
            degreeShowed = true;
        }

        void OnDegreeViewEnds()
        {
            degreeViewScript.DeActivateDegreeView(degreeShowed);
        }

        void OnScissorsAnimEnabled(){
            if (!replay.ReplayMode())
            {
                scissorsScript.ScissorsActivated();
                
            }
        }

        // movement
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
    }
}
