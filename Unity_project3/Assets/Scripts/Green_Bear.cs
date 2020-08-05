using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green_Bear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector2 newScale = transform.localScale;
        newScale.x *= 3;
        transform.localScale = newScale;
    }
}
