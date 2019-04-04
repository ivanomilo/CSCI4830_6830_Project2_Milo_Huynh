using UnityEngine;
using System.Collections;

public class Soundtrig : MonoBehaviour
{

    public OVRPlayerController playerController;
    public AudioClip Sound;
   

    private float throwSpeed = 2000f;
    public AudioSource source;
   // public GameObject audioSource;
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;
    Collider rigidbodycollider;
    bool soundplayed = false; 

    void Awake()
    {

       //source =GetComponent<AudioSource>();
      

    }


void Update()
    {
       

    }



void OnTriggerEnter(Collider other){
         if (other.gameObject.tag == "Player" && !soundplayed) {
             GetComponent<AudioSource> ().clip = Sound;
             GetComponent<AudioSource> ().Play ();
             soundplayed = true;
         }


 /* private void OnCollisionEnter(Collision collision)
    {
        source.PlayOneShot(Sound, 1);
        //Debug.Log("collided with " + collision.gameObject + " soundplayed? "+soundplayed); 
        if ( collision.gameObject.tag == "Player" && !soundplayed)
        {Debug.Log("collided with " + collision.gameObject + " soundplayed? "+soundplayed); 

           // source.PlayOneShot(Sound, 1);
           source.Play(); 
            soundplayed = true;
        }
*/

    }


}