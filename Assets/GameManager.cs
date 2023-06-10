using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Comb;
    public GameObject scissors;
    public List<GameObject> gameObjects;
    private int currentIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonClick()
    {
        if (gameObjects.Count == 0)
        {
            Debug.Log("List is Empty");
            return;
        }

        if (currentIndex >= gameObjects.Count)
        {
            Debug.Log("End of list");
            return;
        }

        // Deact prev obj
        if (currentIndex > 0)
        {
            gameObjects[currentIndex - 1].SetActive(false);
        }

        // Act next obj
        gameObjects[currentIndex].SetActive(true);

        currentIndex++;
    }
}
