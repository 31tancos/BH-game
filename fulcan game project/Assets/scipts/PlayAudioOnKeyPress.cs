using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioOnKeyPress : MonoBehaviour {

    public KeyCode Key;
    public AudioSource TargetAudioSource;
    public float InDelay = 1f;
    private bool acceptingInput = false;
    void Start()
    {
        StartCoroutine(waitThenAcceptInput());
    }

    IEnumerator waitThenAcceptInput()
    {
        yield return new WaitForSeconds(InDelay);
        acceptingInput = true;
    }
    void Update()
    {
        if (acceptingInput && Input.GetKeyDown(Key))
        {
            TargetAudioSource.Play();
            acceptingInput = false;
        }
    }
}
