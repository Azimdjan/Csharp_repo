using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private float prefabColliderX;
    private float prefabColliderY;
    BoxCollider2D mycollider;
    const float MovementUnits = 10f;
    // Start is called before the first frame update
    void Start()
    {
        mycollider = GetComponent<BoxCollider2D>();
        prefabColliderX = mycollider.size.x / 2;
        prefabColliderY = mycollider.size.y / 2;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        SnapToScreen();
    }

    private void Movement()
    {
        Vector2 position = transform.position;
        float horizontalMovementInput = Input.GetAxis("Horizontal");
        float verticalMovementInput = Input.GetAxis("Vertical");
        if(horizontalMovementInput!=0)
        {
            position.x += horizontalMovementInput * MovementUnits * Time.deltaTime;
        }
        if(verticalMovementInput!=0)
        {
            position.y += verticalMovementInput * MovementUnits * Time.deltaTime;
        }
        transform.position = position;
    }

    private void SnapToScreen()
    {
        Vector2 worldPosition = transform.position;
        if(worldPosition.x-prefabColliderX<=ScreenUnits.ScreenLeft)
        {
            worldPosition.x = ScreenUnits.ScreenLeft + prefabColliderX;
        }
        else if(worldPosition.x+prefabColliderX>=ScreenUnits.ScreenRight)
        {
            worldPosition.x = ScreenUnits.ScreenRight - prefabColliderX;
        }
        else if(worldPosition.y-prefabColliderY<=ScreenUnits.ScreenBottom)
        {
            worldPosition.y = ScreenUnits.ScreenBottom + prefabColliderY;
        }
        else if(worldPosition.y+prefabColliderY>=ScreenUnits.ScreenTop)
        {
            worldPosition.y = ScreenUnits.ScreenTop - prefabColliderY;
        }
        transform.position = worldPosition;
    }
}
