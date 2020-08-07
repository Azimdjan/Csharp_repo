using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Jumper : MonoBehaviour
{
    const float minX = 0f;
    const float maxX = 2f;
    const float minY = 0f;
    const float maxY = 3f;
    const float TotalTimeElapsed = 1f;
    float elapsedTimeDelay = 0f;
    private void JumpWithDelay()
    {
        if (elapsedTimeDelay >= TotalTimeElapsed)
        {
            float jump_X = Random.Range(minX, maxX);
            float jump_Y = Random.Range(minY, maxY);
            Vector2 jump = new Vector2(jump_X, jump_Y);
            transform.position = jump;
            elapsedTimeDelay = 0;
        }
    }

    private void Timer()
    {
        elapsedTimeDelay += Time.deltaTime;
    }
    // Update is called once per frame
    void Update()
    {
        Timer();
        JumpWithDelay();
    }
}
