using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleCruiserAI : MonoBehaviour {

    public float Health;
    public float Force;
    public Rigidbody2D RigidBody;

    void Update()
    {
        if (Health != 0)
        {
            RigidBody.AddForce(Vector2.down * Force);
            RigidBody.AddForce(Vector2.right * Force);
        }
    }
}
