using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

    public KeyCode UpKey;
    public KeyCode DownKey;
    public KeyCode LeftKey;
    public KeyCode RightKey;
    public Rigidbody2D RigidBody;
    public float Force;

    void Update()
    {
        if (Input.GetKey(UpKey))
        {
            RigidBody.AddForce(Vector2.up * Force);
        }
        else if (Input.GetKey(DownKey))
        {
            RigidBody.AddForce(Vector2.down * Force);
        }
        if (Input.GetKey(LeftKey))
        {
            RigidBody.AddForce(Vector2.left * Force);
        }
        if (Input.GetKey(RightKey))
        {
            RigidBody.AddForce(Vector2.right * Force);
        }
    }
}
