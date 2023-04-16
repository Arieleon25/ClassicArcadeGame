using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DK_WeaponShooter : MonoBehaviour
{
    public GameObject bullet;
    public Transform muzzle;
    public float bulletSpeed = 20f;

    private bool isPickedUp = false;
    public Transform playerHand;

    void Update()
    {

        if (isPickedUp && Input.GetKeyDown(KeyCode.P))
        {
            PickUp();
        }

        if (isPickedUp && Input.GetKeyDown(KeyCode.K))
        {
            Shoot();
        }

    }

    void Shoot()
    {
        if(isPickedUp)
        {
            GameObject bulletObject = Instantiate(bullet, muzzle.position, muzzle.rotation);
            Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();
            bulletRigidbody.velocity = muzzle.forward * bulletSpeed;
        }
    }

    void PickUp()
    {
        transform.parent = playerHand;
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.identity;
        isPickedUp = true;
        GetComponent<Rigidbody>().isKinematic = true;
    }


}
