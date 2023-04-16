using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DK_HurtPlayer : MonoBehaviour
{
    public AudioClip hitSound;
    private AudioSource hitaudioSource;

    void Start()
    {
        hitaudioSource = gameObject.GetComponent<AudioSource>();
        hitaudioSource.clip = hitSound;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Barrel"))
        {
            hitaudioSource.Play();
        }
    }

}
