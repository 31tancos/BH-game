using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

    public KeyCode UpKey;
    public KeyCode DownKey;
    public KeyCode LeftKey;
    public KeyCode RightKey;
    public KeyCode FireKey;
    public AudioSource TargetAudioSource;
    public Rigidbody2D RigidBody;
    public float Force;

    public GameObject Bullet;
    public Transform BulletSpawn;
    public float FireRate;

    private float nextFire;

    void Update()
    {
        if (Input.GetKey(FireKey) && Time.time > nextFire)
        {
            nextFire = Time.time + FireRate;
            Instantiate(Bullet, BulletSpawn.position, BulletSpawn.rotation);
            TargetAudioSource.Play();
        }

    }

    void FixedUpdate()
    {
        if (Input.GetKey(UpKey))
        {
            RigidBody.AddForce(Vector2.up * Force);
        }
        if (Input.GetKey(DownKey))
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
