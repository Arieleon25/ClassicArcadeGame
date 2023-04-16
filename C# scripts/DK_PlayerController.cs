using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DK_PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; //Speed of player movement
    public float jumpForce = 10f; // Force of player jump
    private LayerMask ladderLayer;
    private bool isClimbing;
    private float climbSpeed = 5f;
    private Rigidbody rbody; //Rigidbody componant of player object
    private bool isGrounded; //is player touching ground?
    public float hitForce = 10f; // The force the pushes the player after getting hit
    //private int coinValueB = 20;

    private Animator animator;
    public float isWalking = 0.0f; 

    public AudioClip jumpSound;
    public AudioClip hitSound;
    public AudioSource jumpAudioSource;
    public AudioSource hitaudioSource;

    void Start()
    {
        rbody = GetComponent<Rigidbody>();

        animator = GetComponent<Animator>();

        jumpAudioSource.clip = jumpSound;
        hitaudioSource.clip = hitSound;
    }


    void Update()
    {
        //Move player based on arrow keys or WASD keys
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //bool isRunning = horizontalInput != 0f || verticalInput != 0f;
        //animator.SetBool("Speed", isRunning);

        //if(verticalInput !=0 && isClimbing)
        //{
        //    Climb(verticalInput);
        //    return;
        //}

        if(isClimbing)
        {
            Vector3 climbDirection = new Vector3(0f, verticalInput, 0f);
            transform.position += climbDirection * climbSpeed * Time.deltaTime;
        }
        
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput)* moveSpeed *Time.deltaTime;
        transform.Translate(moveDirection, Space.World);

        if(moveDirection != Vector3.zero)
        {
            transform.LookAt(transform.position + moveDirection);
            isWalking = 1.0f;
        }
        else
        {
            isWalking = 0.0f;
        }

        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            jumpAudioSource.Play();
            rbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }

        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            CheckForLadder();
        }

        animator.SetFloat("Speed", isWalking);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Checking if player is touching the ground
        if(collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }

        if(collision.gameObject.CompareTag("Barrel"))
        {
            hitaudioSource.Play();
            Vector3 hitDirection = transform.position - collision.transform.position; //Direction of the hit
            rbody.AddForce(hitDirection.normalized * hitForce, ForceMode.Impulse);
        }

    }

    //private void Climb(float verticalInput)
    //{
    //    transform.Translate(Vector3.up * climbSpeed * verticalInput * Time.deltaTime);
    //}

    private void CheckForLadder()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.up, out hit, 1.0f))
        {
            if(!hit.collider.CompareTag("Ladder"))
            {
                isClimbing = false;
            }
        }

        if (Physics.Raycast(transform.position, -transform.up, out hit, 1.0f))
        {
            if (!hit.collider.CompareTag("Ladder"))
            {
                isClimbing = false;
            }

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Ladder"))
        {
            isClimbing = true;
            rbody.useGravity = false;
        }


        //if(other.CompareTag("BarrelPoint"))
        //{
        //    DK_GameManag.Instance.AddScore(coinValueB);
        //}
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Ladder"))
        {
            isClimbing = false;
            rbody.useGravity = true;
        }
    }
}
