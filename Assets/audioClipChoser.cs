using UnityEngine;
using System.Collections;

public class audioClipChoser : MonoBehaviour
{
    public AudioClip[] audioChoices;
    int choice;
    AudioSource myAudioSource;

	// Use this for initialization
	void Start ()
    {
        choice = Random.Range(0, audioChoices.Length);
        myAudioSource = Camera.main.GetComponent<AudioSource>();
        myAudioSource.clip = audioChoices[choice];
        myAudioSource.Play();
    }
}
