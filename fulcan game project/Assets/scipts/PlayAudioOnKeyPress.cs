using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioOnKeyPress : MonoBehaviour {

    public KeyCode Key;
    public AudioSource TargetAudioSource;
    void Update()
    {
        if (Input.GetKeyDown(Key))
        {
            TargetAudioSource.Play();
        }
    }
}
