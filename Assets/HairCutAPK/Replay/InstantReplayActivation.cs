using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Replay;

namespace ReplayExmpleScripts
{
    public class InstantReplayActivation : MonoBehaviour
    {
        public ReplayManager replay;
        [SerializeField] private ScissorsScript scissorsScript;  
        public GameController gameController;      

        // Update is called once per frame
        void Update()
        {
            //Enter replay mode
            if (Input.GetKeyDown(KeyCode.R) && !replay.ReplayMode())
            {
                // gameController.DisableCloth();
                // replay.EnterReplayMode();   
                Invoke(nameof(OnReplayModeEnter), 0.1f);             
            }
        }    

        void OnReplayModeEnter()
        {
            replay.EnterReplayMode();  
        }    
    }
}

