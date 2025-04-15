using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.Callbacks;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody rb;
    public bool onFloor = false;
    public float force = 20f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            onFloor = true;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && onFloor == true)
        {
            rb.AddForce(transform.up * force);
            onFloor = false;
        }   
    }
}
