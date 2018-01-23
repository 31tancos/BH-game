using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMover : MonoBehaviour
{
    public Rigidbody2D RigidBody;
    public bool MoveUp;
    public float Force;
    void Start()
    {
        if (MoveUp == true)
        {
            RigidBody.AddForce(Vector2.up * Force);
        }
        else
        {
            RigidBody.AddForce(Vector2.down * Force);
        }

    }
}

