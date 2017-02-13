using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour {

    private LineRenderer line;
    public Transform origin;
    public Transform destin;

    // Use this for initialization
    void Start () {
        line = GetComponent<LineRenderer>();
        line.startWidth = 0.1f;
        line.endWidth = 0.1f;
    }
	
	// Update is called once per frame
	void Update () {
        line.SetPosition(0, origin.position);
        line.SetPosition(1, destin.position);
    }

}
