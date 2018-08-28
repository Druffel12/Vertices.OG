﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraSwitch : MonoBehaviour {

    public CinemachineClearShot cam1;
   

	// Use this for initialization
	void Start ()
    {
        if (Input.GetKeyDown ("E"))
        {
            cam1.Priority -= 1;
        }
        else if (Input.GetKeyDown("Q"))
        {
            cam1.Priority += 1;
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
