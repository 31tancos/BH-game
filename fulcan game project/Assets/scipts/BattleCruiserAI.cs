using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleCruiserAI : MonoBehaviour {

    public float PlaceHolder;
    public float Force;
    public float EnterForce;
    public float EnterDelay;
    public Rigidbody2D RigidBody;
    public float MoveDelay = 1f;
    IEnumerator Start()
    {
        for(int i=0; 30 > i; i++)
        {
            RigidBody.AddForce(Vector2.down * EnterForce);
            yield return new WaitForSeconds(.1f);
        }
        yield return new WaitForSeconds(EnterDelay);
        RigidBody.AddForce(Vector2.right * Force / 2);
        while (PlaceHolder > 2)
        {
            RigidBody.AddForce(Vector2.left * Force);
            yield return new WaitForSeconds(MoveDelay);
            RigidBody.AddForce(Vector2.right * Force);
            yield return new WaitForSeconds(MoveDelay);
        }
    }
}
