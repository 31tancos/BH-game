using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienScout_movement : MonoBehaviour
{

    public float Force;
    public Rigidbody2D RigidBody;
    public bool MoveRight;
    void Start()
    {
        if (MoveRight == true)
        {
            transform.Rotate(Vector3.forward * 90);
            RigidBody.AddForce(Vector2.right * Force);
        }
        else
        {
            transform.Rotate(Vector3.back * 90);
            RigidBody.AddForce(Vector2.left * Force);
        }
    }
}
