using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpeedScript : MonoBehaviour
{
    public float timer = 5.0f;
    public int speed = 20;
    public GameObject TargetSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(TargetSpeed);
            Debug.Log("Test");
            for (timer = 5; timer > 0; timer--) {



                    speed = 40;
                                            }

              
            }
        }
    }

