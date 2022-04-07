using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DropdownButton : MonoBehaviour {



    public GameObject mainigaisAttels;
    public Sprite[] changingpic;
    public void changepic(int skaitlis)
    {
        switch(skaitlis){
            case 0:
                mainigaisAttels.GetComponent<Image>().sprite = changingpic[0];
                break;
            case 1:
                mainigaisAttels.GetComponent<Image>().sprite = changingpic[1];
                break;

        }


    }
	public GameObject Slider_y;
	public GameObject Slider_x;


	public void changesize(){

		float x = Slider_x.GetComponent<Slider>().value;
		float y = Slider_y.GetComponent<Slider>().value;

		mainigaisAttels.transform.localScale = new Vector3 (1F * x, 1F * y, 1);

	}



}
