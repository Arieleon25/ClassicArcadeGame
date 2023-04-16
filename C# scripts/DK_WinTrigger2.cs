using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DK_WinTrigger2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            DK_GameManag gameManag = GameObject.FindObjectOfType<DK_GameManag>();
            if (gameManag != null)
            {
                gameManag.WinGame2();
            }
        }
    }
}
