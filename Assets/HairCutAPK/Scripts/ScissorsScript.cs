using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Replay;


namespace ReplayExmpleScripts
{
    public class ScissorsScript : MonoBehaviour
    {        
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

        public void OnScissorsActive()
        {
            gameObject.SetActive(true);
        }

        // public void OnScissorsDeActive()
        // {
        //     gameObject.SetActive(false);
        // }
    }
}
