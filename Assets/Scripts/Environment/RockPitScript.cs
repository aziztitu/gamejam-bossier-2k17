﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockPitScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.CompareTag("pecky"))
        {
            PeckyController peckyController = collider.gameObject.GetComponent<PeckyController>();
            peckyController.die();
        }
    }
}
