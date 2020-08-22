using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenUnits
{
    private static float screenLeft;
    private static float screenRight;
    private static float screenBottom;
    private static float screenTop;

    public static float ScreenLeft
    { get { return screenLeft; } }

    public static float ScreenRight
    { get { return screenRight; } }

    public static float ScreenBottom
    { get { return screenBottom; } }

    public static float ScreenTop
    { get { return screenTop; } }

    public static void Initialize()
    {
        Vector2 leftBottomCornerScreen = new Vector2(0, 0);
        Vector2 rightTopCornerScreen = new Vector2(Screen.width, Screen.height);
        Vector2 leftBottomCorner = Camera.main.ScreenToWorldPoint(leftBottomCornerScreen);
        Vector2 rightTopCorner = Camera.main.ScreenToWorldPoint(rightTopCornerScreen);

        screenLeft = leftBottomCorner.x;
        screenRight = rightTopCorner.x;
        screenBottom = leftBottomCorner.y;
        screenTop = rightTopCorner.y;
    }
}
