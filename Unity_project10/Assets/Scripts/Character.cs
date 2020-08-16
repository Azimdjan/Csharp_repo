using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private float colliderHalfWidth;
    private float colliderHalfHeight;
    BoxCollider2D myCollider;
    // Start is called before the first frame update
    void Start()
    {
        myCollider = GetComponent<BoxCollider2D>();
        colliderHalfWidth = myCollider.size.x/2;
        colliderHalfHeight = myCollider.size.y / 2;
    }

    private void SnapToMouse()
    {
        Vector2 position = Input.mousePosition;
        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(position);
        transform.position = worldPosition;
    }
    // Update is called once per frame
    void Update()
    {
        SnapToMouse();
        ClampToScreen();
    }

    private void ClampToScreen()
    {
        Vector2 currentPosition = transform.position;
        if (currentPosition.x - colliderHalfWidth <= ScreenUnits.ScreenLeft)
        {
            currentPosition.x = ScreenUnits.ScreenLeft + colliderHalfWidth;
        }
        else if (currentPosition.x + colliderHalfWidth >= ScreenUnits.ScreenRight)
        {
            currentPosition.x = ScreenUnits.ScreenRight - colliderHalfWidth;
        }
        else if(currentPosition.y-colliderHalfHeight<=ScreenUnits.ScreenBottom)
        {
            currentPosition.y = ScreenUnits.ScreenBottom + colliderHalfHeight;
        }
        else if(currentPosition.y+colliderHalfHeight>=ScreenUnits.ScreenTop)
        {
            currentPosition.y = ScreenUnits.ScreenTop - colliderHalfHeight;
        }
        transform.position = currentPosition;
    }
}
