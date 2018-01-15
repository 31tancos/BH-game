using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMover : MonoBehaviour {
    public Rigidbody2D RigidBody;
    public float Force;
    public float LifeTime;
    public float SwingDelay;
    void Start()
    {
     RigidBody.velocity = transform.up * Force;
    }
}

