using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parachute : MonoBehaviour
{

    public KeyCode openParachute;
    public KeyCode closeParachute;
    public Transform parachuteMesh;

    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        parachuteMesh.GetComponent<Renderer>().enabled = false;
   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(openParachute))
        {
            rb.drag = 3f;
            parachuteMesh.GetComponent<Renderer>().enabled = true;
        }
        if (Input.GetKeyDown(closeParachute))
        {
            rb.drag = 0f;
            parachuteMesh.GetComponent<Renderer>().enabled = false;
        }
    }



}
