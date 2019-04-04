using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transport : MonoBehaviour
{

    public GameObject spawn;
    public GameObject survey;
    public OVRPlayerController playerController; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   void OnTriggerEnter(Collider other){
    Debug.Log("Logging collision on light");
     
            //playerController.transform.position = spawn.transform.position;
        survey.active = true;
    }
}
