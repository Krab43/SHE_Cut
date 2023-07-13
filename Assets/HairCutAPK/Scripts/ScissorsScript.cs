using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Replay;


namespace ReplayExmpleScripts
{
    public class ScissorsScript : MonoBehaviour
    {        
        public GameObject degreeView;
        public Animator anim;
        private bool degreeShowed = false;
        private float degreeDelay = 2f;
        private bool hairReleased = false;
        public BoneStrandScript boneStrandScript;
        public ConnectorScript connectorScript;
        public HairScript hairScript;

        private void Start() {
            // anim = GetComponent<Animator>();
        }
        // private ReplayManager replay; 
        
        // private void Awake() {
        // }
        // // Start is called before the first frame update
        // void Start()
        // {
        //     replay = FindObjectOfType<ReplayManager>();
        // }

        // // Update is called once per frame
        // void Update()
        // {
        //     // if (Input.GetKeyDown(KeyCode.R) && !replay.ReplayMode())
        //     // {                
        //     //     OnScissorsActive();            
        //     // }
        // }    
        // public void OnScissorsDeActive()
        // {
        //     gameObject.SetActive(false);
        // }

        public void OnScissorsActive()
        {
            gameObject.SetActive(true);
            Invoke(nameof(OnDegreeView), 0.5f);
            
            if (degreeShowed)
            {
                anim.enabled = true;
                Invoke(nameof(HairReaction), 1f);
            }
        }

        void HairReaction(){
                if (!hairReleased)
                    {
                        boneStrandScript.OnFixedHairReleased();
                        hairReleased = true;
                    }
                hairScript.OnGravityEnebled();
                connectorScript.OnConectorCutted();
        }
        
        void DeActivateDegreeView()
        {
            degreeView.SetActive(false);
            
            if (!degreeView.activeSelf)
            {
                degreeShowed = true;
            }
        }

        void OnDegreeView()
        {
            if (!degreeShowed)
            {
                degreeView.SetActive(true);
                Invoke(nameof(DeActivateDegreeView), degreeDelay);
            }                
        }
    }
}
