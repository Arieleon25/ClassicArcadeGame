using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DK_EnemyAI : MonoBehaviour
{
    public float speed = 10f;
    public float torque = 10f;
    public float repelForce = 10f;
    private Rigidbody rbody;
    //public Animator anim;
    public int damage = 1;

    void Start()
    {
        rbody = GetComponent<Rigidbody>();
        rbody.AddTorque(transform.forward * torque);
        rbody.AddForce(transform.right * speed, ForceMode.VelocityChange);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Barrel"))
        {
            Vector3 repelVector = transform.position - collision.contacts[0].point;

            repelVector.Normalize();
            GetComponent<Rigidbody>().AddForce(repelVector * repelForce, ForceMode.Impulse);
        }

        if(collision.gameObject.CompareTag("Player"))
        {
            DK_GameManag gameManager = GameObject.FindObjectOfType<DK_GameManag>();
            if(gameManager != null)
            {
                gameManager.Loselife(damage);
                Debug.Log("Ramining lives: " + gameManager.GetLives());
            }
        }
    }
}
