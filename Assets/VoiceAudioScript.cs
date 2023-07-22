using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceAudioScript : MonoBehaviour
{
    public List<AudioClip> clips;
    private AudioSource audioSource;
    int currentIndex;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
    }

    // Update is called once per frame
   void Update()
{
    if (!audioSource.isPlaying)
    {
        currentIndex++;
        if (currentIndex >= clips.Count)
        {
            currentIndex = 0; // Зациклюємо індекс, якщо він виходить за межі списку
        }
        audioSource.clip = clips[currentIndex];
        audioSource.Play();
    }
}

public void OnButtonClick()
{
    currentIndex++;
    if (currentIndex >= clips.Count)
    {
        currentIndex = 0; // Зациклюємо індекс, якщо він виходить за межі списку
    }
}






}
