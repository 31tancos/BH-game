using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomAlphaEffect : MonoBehaviour
{
    public Text Text;
    public float Delay;
    public float MinAlpha;
    public float MaxAlpha;

    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(Delay);
            Text.material.color = new Color(
                Text.color.r,
                Text.color.g,
                Text.color.b,
                Random.Range(MinAlpha, MaxAlpha));
            yield return null;
        }
    }
}
