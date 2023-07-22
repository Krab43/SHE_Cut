using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Replay;
using UnityEngine.UI;
namespace ReplayExmpleScripts
{
public class GameManager : MonoBehaviour
{
    
    public List<GameObject> zones;
    private int currentIndex = 0;   
    public ReplayManager replay;
    public Slider slider;
    [SerializeField] float progress = 0f;
    
    void Start()
    {
        slider.minValue = 0f;
        slider.maxValue = zones.Count;
        slider.value = 0f;
    }  
  

   public void UpdateSliderValue()
   {
        float step = 1f / slider.maxValue;
        // float progress = 0f;
        // foreach (GameObject obj in zones)
        // {
            // if (obj.activeSelf)
            // {
                progress += step;
            // }        
        // }
        slider.value = progress;
        // progress ++;
   }
    
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
            // Destroy(zones[currentIndex - 1]);
        }

        // Act next obj
        zones[currentIndex].SetActive(true);

        currentIndex++;
    }
}
}
