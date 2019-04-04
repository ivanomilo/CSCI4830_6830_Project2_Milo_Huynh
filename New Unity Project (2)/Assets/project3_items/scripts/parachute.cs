using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parachute : MonoBehaviour
{

    //public KeyCode openParachute;
    //public KeyCode closeParachute;
    
  
    public Transform parachuteMesh;
    public OVRPlayerController player;
    public Rigidbody rb;
    float initdrag = 0.379f;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        parachuteMesh.GetComponent<Renderer>().enabled = false;
   
    }

    // Update is called once per frame
    void Update()
    {
       
        //if (Input.GetKeyDown(openParachute))
        if(OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger)!=0)
        {
            player.GravityModifier = 0.009f; 
            
            //rb.drag = 3f;
            parachuteMesh.GetComponent<Renderer>().enabled = true;
        }
        //else if (Input.GetKeyDown(closeParachute))
        else
        {
            player.GravityModifier = initdrag;
            parachuteMesh.GetComponent<Renderer>().enabled = false;
        }
    }



}
