using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Show_Value : MonoBehaviour {

    Text textValue;

	void Start () {

        textValue = GetComponent<Text>();
		
	}

	
	public void textUpdate (float value) {

        textValue.text = value.ToString();      // update slider value
		
	}


}
