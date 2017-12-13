using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimationOnKeyPress : MonoBehaviour {

    // Use this for initialization
    public KeyCode Key;
    public string TriggerName;
    public Animator Animator;

    void Update()
    {
        if (Input.GetKeyDown(Key))
        {
            Animator.SetTrigger(TriggerName);
        }
    }
}
