using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed = 200;
    public int jumpForce = 20;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float mouseInput = Input.GetAxis("Mouse X");

        Vector3 lookhere = new Vector3(0, mouseInput, 0);

        transform.Rotate(lookhere);

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * jumpForce * Time.deltaTime);
        }
    }
}