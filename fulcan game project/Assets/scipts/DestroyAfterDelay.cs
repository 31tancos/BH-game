using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterDelay : MonoBehaviour
{
    public float lifeTime = 1f;

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }
}
