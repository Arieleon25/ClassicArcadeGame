using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DK_HammerDamage : MonoBehaviour
{
    public int damage = 3;

    public AudioClip hitSound;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = hitSound;
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            audioSource.Play();
            DK_GameManag gameManager = GameObject.FindObjectOfType<DK_GameManag>();
            if (gameManager != null)
            {
                gameManager.Loselife(damage);
                Debug.Log("Ramining lives: " + gameManager.GetLives());
            }
        }
    }
}
