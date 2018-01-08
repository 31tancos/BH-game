using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimationOnKeyPress : MonoBehaviour {

    public KeyCode Key;
    public string TriggerName;
    public Animator Animator;
    public float InDelay = 1f;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(InDelay);

        while (!Input.GetKeyDown(Key))
        {
            yield return null;
        }
        Animator.SetTrigger(TriggerName);
    }
}
