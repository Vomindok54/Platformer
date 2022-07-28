using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float speed = .75f;
    Rigidbody2D rb;
    public GameObject projectilePrefab;
    public Transform gun;

    public bool canShoot = true;
    public float timer = 0f;
    public float shotsPerSecond = 1;

    void Update()
    {
        timer += Time.deltaTime; //deltaTime is the amount of time in ms since last frame
        if (canShoot == true && timer > shotsPerSecond)
        {
            Shoot();
            timer = 0f;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Shoot()
    {
        //Clone a bullet and spawn it at the gun's position using our rotation
        Instantiate(projectilePrefab, gun.position, transform.rotation) ;
    }

}
