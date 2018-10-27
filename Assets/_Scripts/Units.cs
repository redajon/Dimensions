using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Units : MonoBehaviour {

    public Dropdown dropdownMenu;
    public Slider lengthSliderMajor, lengthSliderMinor;
    public Slider widthSliderMajor, widthSliderMinor;
    public Slider heightSliderMajor, heightSliderMinor;
    public Text units;

    public static string areaUnit, volumeUnit;


	void Update () {

        if (dropdownMenu.value == 0) {                                          // imperial

            areaUnit = "feet";
            volumeUnit = "gallons";
            lengthSliderMajor.maxValue =  widthSliderMajor.maxValue = heightSliderMajor.maxValue = 100;
            lengthSliderMinor.maxValue = widthSliderMinor.maxValue = heightSliderMinor.maxValue = 12;
            units.text = " feet  inches         feet inches         feet inches";
        }

        else {                                                                  // metric

            areaUnit = "metres";
            volumeUnit = "litres";
            lengthSliderMajor.maxValue = widthSliderMajor.maxValue = heightSliderMajor.maxValue = 30;
            lengthSliderMinor.maxValue = widthSliderMinor.maxValue = heightSliderMinor.maxValue = 100;
            units.text = " metres cm            metres cm           metres cm";
        }

    }


}
