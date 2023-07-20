using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ReplayExmpleScripts
{
    public class DegreeViewScript : MonoBehaviour
    {

        public GameObject combMain;
        bool degreeShowed = false;
        public CombScript combscript;
        
        // private void OnEnable() {
        //     Invoke(nameof(DeActivateDegreeView), 2f);
        // }

        public void DeActivateDegreeView(bool showed)
            {
                combMain.SetActive(true);
                degreeShowed = true;

                if(degreeShowed){
                    gameObject.SetActive(false);           
                }
                showed = degreeShowed;

                combscript.DegreeShowTrue();
            }
    }
}
