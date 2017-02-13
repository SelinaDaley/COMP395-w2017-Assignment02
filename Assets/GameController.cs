using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public GameObject weight;
    public Text weightText;
    public Text minText;
    public Text maxText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangeMinText(string value)
    {        
        weight.GetComponent<SpringJoint>().minDistance = float.Parse(value);
    }

    public void ChangeMaxText(string value)
    {
        weight.GetComponent<SpringJoint>().maxDistance = float.Parse(value);
    }

    public void ChangeMass(float value)
    {
        weightText.text = "Weight: " + value;
        weight.GetComponent<Rigidbody>().mass = value;
    }
}
