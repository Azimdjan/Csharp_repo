using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yellow_Bear : MonoBehaviour
{
    void Start()
    {
        Vector2 newScale = transform.localScale;
        newScale.x *= 4;
        newScale.y *= 4;
        transform.localScale = newScale;
    }
}
