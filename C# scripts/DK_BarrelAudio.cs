using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DK_BarrelAudio : MonoBehaviour
{
    public AudioClip rollingSound;
    public float maxAudibleDistance = 10f;
    private AudioSource audioSource;
    private Transform playerTransform;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = rollingSound;
        audioSource.loop = true;
        audioSource.Play();

        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, playerTransform.position);

        float volume = Mathf.Clamp01(1 - (distanceToPlayer / maxAudibleDistance));
        audioSource.volume = volume;
    }
    private void OnDestroy()
    {
        audioSource.Stop();
    }
}
