using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioOnKeyPress : MonoBehaviour {

    public KeyCode Key;
    public AudioSource TargetAudioSource;
    public float InDelay = 1f;
    private bool acceptingInput = false;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(InDelay);

        while (!Input.GetKeyDown(Key))
        {
            yield return null;
        }
        TargetAudioSource.Play();

    }
}
