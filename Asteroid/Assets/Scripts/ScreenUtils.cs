using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class ScreenUtils
{
    static float leftScreen;
    static float rightScreen;
    static float bottomScreen;
    static float topScreen;

    public static float LeftScreen
    { get { return leftScreen; } }

    public static float RightScreen
    { get { return rightScreen; } }

    public static float BottomScreen
    { get { return bottomScreen; } }

    public static float TopScreen
    { get { return topScreen; } }

    public static void Initialize()
    {
        Vector2 bottom_Screen = new Vector2(0, 0);
        Vector2 top_Screen = new Vector2(Screen.width, Screen.height);
        Vector2 bottomWorld = Camera.main.ScreenToWorldPoint(bottom_Screen);
        Vector2 topWorld = Camera.main.ScreenToWorldPoint(top_Screen);

        leftScreen = bottomWorld.x;
        rightScreen = topWorld.x;
        bottomScreen = bottomWorld.y;
        topScreen = topWorld.y;
    }

}
