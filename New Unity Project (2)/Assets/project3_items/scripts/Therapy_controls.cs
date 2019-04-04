using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Therapy_controls : MonoBehaviour
{
    public GameObject wall1L;
    public GameObject wall1R;
    public GameObject floor1;

    public GameObject wall2L;
    public GameObject wall2R;
    public GameObject floor2;

    public GameObject wall3L;
    public GameObject wall3R;
    public GameObject floor3;

    public int width;

    public GameObject blimp;
    public int blimp_height;

    Vector3 blimp_og_position;
    Vector3 wall1_og_position;
    Vector3 wall2_og_position;
    Vector3 wall3_og_position;

    float max_distance_wall;
    float max_distance_wall_long;
    // Start is called before the first frame update
    void Start()
    {
        blimp_og_position = blimp.transform.position;
        wall1_og_position = wall1L.transform.position;
        wall2_og_position = wall2L.transform.position;
        wall3_og_position = wall3L.transform.position;

        max_distance_wall = floor2.GetComponent<Collider>().bounds.extents.z/32;

        max_distance_wall_long = floor1.GetComponent<Collider>().bounds.extents.x/50; 
    }

    // Update is called once per frame
    void Update()
    {
        int corridor_width = 10 +width; 
        if(corridor_width > 12)
        {
            corridor_width = 12; 
        }
        if(corridor_width < 1)
        {
            corridor_width = 1; 
        }
        //blimp
        Vector3 blimp_transform = new Vector3(0, blimp_height, 0);
        blimp.transform.position  = blimp_og_position + blimp_transform;

        wall1L.transform.position = wall1_og_position + new Vector3(max_distance_wall_long * corridor_width,0,0);
        wall1R.transform.position = wall1_og_position - new Vector3(max_distance_wall_long * corridor_width,0,0);

        wall2L.transform.position = wall2_og_position + new Vector3(0, 0, max_distance_wall * corridor_width);
        wall2R.transform.position = wall2_og_position - new Vector3(0, 0, max_distance_wall * corridor_width);

        wall3L.transform.position = wall3_og_position + new Vector3(0, 0, max_distance_wall * corridor_width);
        wall3R.transform.position = wall3_og_position - new Vector3(0, 0, max_distance_wall * corridor_width);
    }
}
