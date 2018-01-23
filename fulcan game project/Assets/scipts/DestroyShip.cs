using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyShip : MonoBehaviour {

    public float Health;
    public string Hazard;
void OnTriggerEnter2D (Collider2D other)
{
    if (other.gameObject.name == Hazard)
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
