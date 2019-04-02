﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadlampControl : MonoBehaviour
{
    public KeyCode toggle;
    public KeyCode UpBrightness;
    public KeyCode DownBrightness;
    public GameObject light;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(toggle))
        {
            light.active = !light.active;
        }
        if (Input.GetKeyDown(UpBrightness))
        {
            light.GetComponent<Light>().intensity++;
        }
        if (Input.GetKeyDown(DownBrightness))
        {
            light.GetComponent<Light>().intensity--;
        }
    }
}
