using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetJumpScript : MonoBehaviour
{
    float jumpForce = 50.0f;
    bool jumping = false;
    public float timer = 5.0f;

    public GameObject Target;
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
            Destroy(Target);
            for (timer = 5; timer > 0; timer--) {

                float jumpForce = 100.0f;
                bool jumping = true;
            }
        }
    }

}
