using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DK_Coin : MonoBehaviour
{
    public int coinValue = 50;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Coin Collected!");
            DK_GameManag.Instance.AddScore(coinValue);
            Destroy(gameObject);
        }
    }
}
