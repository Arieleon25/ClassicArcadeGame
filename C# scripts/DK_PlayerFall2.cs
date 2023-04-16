using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DK_PlayerFall2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            DK_GameManag gameManag = GameObject.FindObjectOfType<DK_GameManag>();
            if(gameManag != null)
            {
                gameManag.LoseGamefall2();
            }
        }
    }
}
