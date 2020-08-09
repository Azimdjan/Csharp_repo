using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Resizer : MonoBehaviour
{
    const float TotalTimeElapsed = 3f;
    float elapsedTime = 0f;
    const float ScaleFactor = 2f;
    int ScaleSignFactor = 1;

    private void Timer()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= TotalTimeElapsed)
        {
            elapsedTime = 0;
            ScaleSignFactor *= -1;
        }
    }

    private void Resize()
    {
        Vector2 resize = transform.localScale;
        resize.x += Time.deltaTime*ScaleFactor*ScaleSignFactor;
        resize.y += Time.deltaTime*ScaleFactor * ScaleSignFactor;
        transform.localScale = resize;
    }
    // Update is called once per frame
    void Update()
    {
        Timer();
        Resize();
    }
}
