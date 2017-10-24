using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrackedObjectsManager : MonoBehaviour {

    public Text trackedText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Test()
    {
        trackedText.text = "***TEST***";
    }
}
