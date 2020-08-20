using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class GameInitializer : MonoBehaviour
{
    private void Awake()
    {
        ScreenUnits.Initialize();
    }
}
