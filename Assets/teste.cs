using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teste : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButtonDown("XButton"))
            Debug.Log("XButton");
        if (Input.GetButtonDown("CircleButton"))
            Debug.Log("CircleButton");
        if (Input.GetButtonDown("SquareButton"))
            Debug.Log("SquareButton");
        if (Input.GetButtonDown("TriangleButton"))
            Debug.Log("TriangleButton");
    }
}
