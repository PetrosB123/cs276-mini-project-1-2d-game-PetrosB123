using UnityEngine;

public class SoundPitchRandomizer : MonoBehaviour
{
    public AudioSource audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource.volume = Random.Range(0.5f, 1.0f);

        audioSource.pitch = Random.Range(0.8f, 1.2f);

        // Play the audio

        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
