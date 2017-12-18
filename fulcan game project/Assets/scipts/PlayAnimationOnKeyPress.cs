using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimationOnKeyPress : MonoBehaviour {

    // Use this for initialization
    public KeyCode Key;
    public string TriggerName;
    public Animator Animator;
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
        if ( acceptingInput && Input.GetKeyDown(Key))
        {
            Animator.SetTrigger(TriggerName);
            acceptingInput = false;
        }
    }
}
