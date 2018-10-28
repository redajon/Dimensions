using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculate : MonoBehaviour {

    public Slider lengthMajor, lengthMinor;
    public Slider widthMajor, widthMinor;
    public Slider heightMajor, heightMinor;

    public Text result;

    public int paintCoveragePerLitre;

    float length, width, height;
    float floorArea, paintArea, paintRequired, volume;


    public void CalculateResults() {

        if (Units.areaUnit == "feet") {

            length = (((lengthMajor.value * 12) + lengthMinor.value) / 12);         // convert feet *and inches* to feet
            width = (((widthMajor.value * 12) + widthMinor.value) / 12);
            height = (((heightMajor.value * 12) + heightMinor.value) /12);
        }
        else {

            length = (((lengthMajor.value * 100) + lengthMinor.value) / 100);       // convert metres *and cm* to metres
            width = (((widthMajor.value * 100) + widthMinor.value) / 100);
            height = (((heightMajor.value * 100) + heightMinor.value) / 100);
        }

        if (length != 0 && width != 0 && height != 0) {                             // check for any zero values

            floorArea = (length * width);                                            // floor area calculation

            paintArea = ((length * height) * 2) + ((width * height) * 2);            // paint calculation

            paintRequired = Mathf.Ceil(paintArea / paintCoveragePerLitre);

            if (Units.volumeUnit == "gallons") {

                paintRequired /= (int)4.516;                                         // convert litres to gallons
            }

            volume = (length * width * height);                                     // volume calculation

            result.text = ("Floor area : " + floorArea.ToString() + " square " + Units.areaUnit + "\n\n" +
              "You will need approx.\n" + paintRequired.ToString() + " " + Units.volumeUnit + " of paint\nfor the walls\n\n" +
              "Room volume : " + volume.ToString() + " square " + Units.areaUnit);

        }
        else {

            result.text = ("Invalid zero entry");
        }

    }


}
