using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float fireRate = 1.1f;
    private float nextFire = 0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, if enough time has passed since last fire time send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            //Add current time to fire rate
            nextFire = Time.time + fireRate;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
