using UnityEngine;
using System.Collections;

public class Soundtrig : MonoBehaviour
{

  
    public AudioClip Sound;
   

    private float throwSpeed = 2000f;
    private AudioSource source;
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;
    Collider rigidbodycollider;
    bool soundplayed = false; 

    void Awake()
    {

        source = GetComponent<AudioSource>();
      

    }


void Update()
    {
       

    }

    private void OnCollisionEnter(Collision collision)
    {
        source.PlayOneShot(Sound, 1);
        Debug.Log("collided with " + collision.gameObject); 
        if (collision.gameObject.tag == "RigidBodyFPSController" && !soundplayed)
        {
            source.PlayOneShot(Sound, 1);
            soundplayed = true;
        }


    }


}