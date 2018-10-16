using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour {

    public GameObject FlippableObjects;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.F))
        {
           
            foreach (Transform child in FlippableObjects.transform)
            {
                child.transform.RotateAround(transform.position,Vector3.up, 180);
            }
        }
	}
}
