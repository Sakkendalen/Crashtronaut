﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour {

    public float RotateX;
    public float RotateY;
    public float RotateZ;
	public float Speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(RotateX * Speed, RotateY * Speed, RotateZ * Speed));
	}
}
