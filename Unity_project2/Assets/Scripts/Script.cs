using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Script : MonoBehaviour
{
    double firstOriginal_Far = 0;
    double secondOriginal_Far = 32;
    double thirdOriginal_Far = 212;
    double firstTemp_Cel, secondTemp_Cel, thirdTemp_Cel;
    double firstCal_Far, secondCal_Far, thirdCal_Far;

    void Start()
    {
        firstTemp_Cel = (firstOriginal_Far - 32) / 9 * 5;
        secondTemp_Cel = (secondOriginal_Far - 32) / 9 * 5;
        thirdTemp_Cel = (thirdOriginal_Far - 32) / 9 * 5;
        print($"First Temperature in celsi: {firstTemp_Cel} C");
        print($"Second Temperature in celsi: {secondTemp_Cel} C");
        print($"Third temperature in celsi: {thirdTemp_Cel} C");

        firstCal_Far = firstTemp_Cel * 9 / 5 + 32;
        secondCal_Far = secondTemp_Cel * 9 / 5 + 32;
        thirdCal_Far = thirdTemp_Cel * 9 / 5 + 32;
        print($"First temperature in farenheit: {firstCal_Far} F");
        print($"Second temperature in farenheit: {secondCal_Far} F");
        print($"Third temperature in farenheit: {thirdCal_Far} F");
    }
}
