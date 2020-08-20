using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenUnits
{
    private static float screenLeft;
    private static float screenRight;
    private static float screenTop;
    private static float screenBottom;

    public static float ScreenLeft
    { get { return screenLeft; } }

    public static float ScreenRight
    { get { return screenRight; } }

    public static float ScreenTop
    { get { return screenTop; } }

    public static float ScreenBottom
    { get { return screenBottom; } }

    public static void Initialize()
    {
        Vector2 leftBottomCorner = new Vector2(0, 0);
        Vector2 rightTopCorner = new Vector2(Screen.width, Screen.height);
        Vector2 worldLeftBottomCorner = Camera.main.ScreenToWorldPoint(leftBottomCorner);
        Vector2 worldRightTopCorner = Camera.main.ScreenToWorldPoint(rightTopCorner);

        screenLeft = worldLeftBottomCorner.x;
        screenRight = worldRightTopCorner.x;
        screenTop = worldRightTopCorner.y;
        screenBottom = worldLeftBottomCorner.y;
    }
}
