using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ToggleButtons : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		
	}


	public GameObject Gloves;
	public GameObject Jacket;
	public GameObject Hat;

	public void Gloves_Show( bool value){

		Gloves.SetActive (value);

	}
	public void Jacket_Show( bool value){

		Jacket.SetActive (value);

	}
	public void Hat_Show( bool value){

		Hat.SetActive (value);

	}
}
