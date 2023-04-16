using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DK_DestroyerManag : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Barrel"))
        {
            Destroy(other.gameObject);
        }
    }
}
