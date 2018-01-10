﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleCruiserAI : MonoBehaviour {

    public float Health;
    public float Force;
    public Rigidbody2D RigidBody;
    public float MoveDelay = 1f;

    IEnumerator Start()
    {
        RigidBody.AddForce(Vector2.right * Force / 2);
        while (Health != 0)
        {
            RigidBody.AddForce(Vector2.left * Force);
            yield return new WaitForSeconds(MoveDelay);
            RigidBody.AddForce(Vector2.right * Force);
            yield return new WaitForSeconds(MoveDelay);
         }
    }
    /*void Update()
    {

        if (Health != 0)
        {
            RigidBody.AddForce(Vector2.down * Force);
            RigidBody.AddForce(Vector2.right * Force);
        }
    }*/
}
