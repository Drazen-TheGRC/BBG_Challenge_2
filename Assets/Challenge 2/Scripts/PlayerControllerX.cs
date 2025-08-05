using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float fireRate = 1.0f;   // seconds between fires
    private float nextFire = 0.0f;   // next allowed fire time

    // Update is called once per frame
    void Update()
    {
        // Check for spacebar press AND if enough time has passed
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;  // reset the cooldown
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
