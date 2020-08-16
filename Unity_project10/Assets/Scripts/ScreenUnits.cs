using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class ScreenUnits 
{
    static float screenLeft;
    static float screenRight;
    static float screenTop;
    static float screenBottom;

    public static float ScreenLeft
    {
        get { return screenLeft; }
    }

    public static float ScreenRight
    {
        get { return screenRight; }
    }

    public static float ScreenTop
    { 
        get { return screenTop; } 
    }

    public static float ScreenBottom
    {
        get { return screenBottom; }
    }

    public static void Initialize()
    {
        Vector2 ScreenBottomLeft = new Vector2(0, 0);
        Vector2 ScreenTopRight = new Vector2(Screen.width, Screen.height);
        Vector2 WorldBottomLeft = Camera.main.ScreenToWorldPoint(ScreenBottomLeft);
        Vector2 WorldTopRight = Camera.main.ScreenToWorldPoint(ScreenTopRight);
        
        screenLeft = WorldBottomLeft.x;
        screenRight = WorldTopRight.x;
        screenTop = WorldTopRight.y;
        screenBottom = WorldBottomLeft.y;
    }

}
