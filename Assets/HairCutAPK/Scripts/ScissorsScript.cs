using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Replay;
using EZhex1991.EZSoftBone;


namespace ReplayExmpleScripts
{
    public class ScissorsScript : MonoBehaviour
    {        
        public Animator anim;
        private bool hairReleased = false;
        public BoneStrandScript boneStrandScript;
        public ConnectorScript connectorScript;
        public HairScript hairScript;
        
        public EZSoftBone ezSoftBoneScript;

        public GameObject scissorsObj;

        private void Start() {
            scissorsObj.SetActive(false);            
        }

        private void Update() {
            if (scissorsObj.activeSelf)
            {
                ezSoftBoneScript.enabled = true; 
            }
            
        }

        public void ScissorsActivated(){
            scissorsObj.SetActive(true);
            anim.Play("SCISSORS");
            // OnScissorsAnimEnabled();
            anim.enabled = true;
            Invoke(nameof(HairReaction), .2f);
        }        

        // public void OnScissorsAnimEnabled()
        // {

        //     anim.enabled = true;
        //     Invoke(nameof(HairReaction), .2f);
        // }

        void HairReaction(){
            if (!hairReleased)
                {
                    if (boneStrandScript.enabled == false)
                    {
                        boneStrandScript.enabled = true;
                    }
                    hairReleased = true;
                }

            hairScript.OnGravityEnebled();
            connectorScript.OnConectorCutted();
        }
    }
}
