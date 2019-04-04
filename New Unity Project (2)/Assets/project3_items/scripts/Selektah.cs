using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selektah : MonoBehaviour
{
    public GameObject fpsCam;
    public float range = 100f;
    private Color og_color = new Color(255,0,0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       ///if (Input.GetButtonDown("Fire1"))
     RaycastHit hit;
          if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            if(hit.collider.tag == "survey_selektah")
            {
                if(hit.collider.gameObject.GetComponent<Light>().color == og_color){
                    hit.collider.gameObject.GetComponent<Light>().color = new Color(255,18,255);
                }
                else{
                    hit.collider.gameObject.GetComponent<Light>().color = og_color; 
                }
            }
            
            
        }
        
    }}

  


