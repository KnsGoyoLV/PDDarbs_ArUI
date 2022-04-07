using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DropDown : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		
	}

	public void Poga(){


	}


	public string Name;
	public string Year;
	public GameObject Name_Input;
	public GameObject Year_Input;
	public GameObject Text_Output;
	public GameObject Text_Output2;

	public void SaveText(){
		Name = Name_Input.GetComponent<Text> ().text;
		Year = Year_Input.GetComponent<Text> ().text;


		Text_Output.GetComponent<Text>().text = "Sveiki " + Name.ToUpper() + "!";
		Text_Output2.GetComponent<Text> ().text = "Tev ir " + Year + " Gadi!";

	}



}
