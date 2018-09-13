using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayController : MonoBehaviour {

    private AudioSource[] sources;

	// Use this for initialization
	void Start () {
        sources = gameObject.GetComponents<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void WaterClicked(){
        sources[0].Play();
    }
}
