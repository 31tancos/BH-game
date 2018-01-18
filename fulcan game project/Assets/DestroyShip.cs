using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyShip : MonoBehaviour {

    public float Health;

void OnTriggerEnter(Collider other)
{
    if (other.gameObject.name == "Playerlaser")
    {
        Health -= 1;
            Destroy(other.gameObject);
            if (Health == 0)
        {
            Destroy(gameObject);
        }
    }
}
}
