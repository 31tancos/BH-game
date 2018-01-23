using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienScout_Shoot : MonoBehaviour {

    public GameObject SmallBullet;
    public float FireDelay;
    public Transform BulletSpawn;
    public AudioSource TargetAudioSource;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(FireDelay);
        for (int i = 0; 3 >= i; i++)
        {
            yield return new WaitForSeconds(FireDelay);
            Instantiate(SmallBullet, BulletSpawn.position, BulletSpawn.rotation);
            TargetAudioSource.Play();
        }
    }
}
