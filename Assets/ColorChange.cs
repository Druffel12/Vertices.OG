﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {

    public Color[] colors;

    public int currentIndex = 0;
    private int nextIndex;

    public float changeColorTime = 2.0f;

    private float lastChange = 0.0f;
    private float timer = 0.0f;

    //public MaterialColor;

    void Start()
    {
        if (colors == null || colors.Length < 2)
            Debug.Log("Need to setup colors array in inspector");

        nextIndex = (currentIndex + 1) % colors.Length;
    }

    void Update()
    {

        timer += Time.deltaTime;

        if (timer > changeColorTime)
        {
            currentIndex = (currentIndex + 1) % colors.Length;
            nextIndex = (currentIndex + 1) % colors.Length;
            timer = 0.0f;

        }
        //renderer.material.color = Color.Lerp(colors[currentIndex], colors[nextIndex], timer / changeColorTime);
    }
}