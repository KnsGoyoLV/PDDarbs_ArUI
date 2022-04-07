using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour {

	public AudioSource audio;
	void Start()
	{
		audio = GetComponent<AudioSource>();
		audio.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
