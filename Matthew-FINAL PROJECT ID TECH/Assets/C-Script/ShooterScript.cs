using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterScript : MonoBehaviour
{
    public GameObject Arrow;
    public bool canShoot;
    public float timeBetweenShots = 1;
    private float timeUntilNextShot;
    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeUntilNextShot)
        {
            canShoot = true;
        }
        if (Input.GetMouseButtonDown(0) && canShoot)
        {
            canShoot = false;
            timeUntilNextShot = Time.time + timeBetweenShots;
            Instantiate(Arrow, this.transform.position, this.transform.rotation);
        }
    }
}