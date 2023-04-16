using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DK_FallingHammer : MonoBehaviour
{
    public Animator animator;
    public string animationName;
    public GameObject triggerObject;

    private bool triggerActivated = false;

    public float opacity = 0.5f;
    public GameObject objectHide;
    private Renderer objectRender;

    private void Start()
    {
        //Getting the render component of the object to hide
        objectRender = objectHide.GetComponent<Renderer>();

        //Set the object;s opacity
        Color objectColor = objectRender.material.color;
        objectColor.a = opacity;
        objectRender.material.color = objectColor;

        //Hide the object
        objectHide.SetActive(false);

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == triggerObject)
        {
            triggerActivated = true;
        }

        if (other.gameObject.CompareTag("Player"))
        {
            objectHide.SetActive(true);

            Color objectColor = objectRender.material.color;
            objectColor.a = 1f;
            objectRender.material.color = objectColor;

            Debug.Log("Player entered collider");
            animator.Play(animationName);
        }

        else
        {
            animator.StopPlayback();
        }
    }

}
