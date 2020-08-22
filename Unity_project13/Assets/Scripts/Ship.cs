using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    Rigidbody2D myRigidBody;
    CircleCollider2D myCollider;
    float thrustAmount = 4f;
    Vector2 thrustDirection = new Vector2(1, 0);
    float radiusOfCollider;
    float rotateDegreesPerSecond = 30f;
    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<CircleCollider2D>();
        radiusOfCollider = myCollider.radius;
    }

    private void Thrust()
    {
        if(Input.GetAxis("Thrust")>0)
        {
            myRigidBody.AddForce(thrustAmount * thrustDirection, ForceMode2D.Force);
        }
    }

    private void OnBecameInvisible()
    {
        Vector2 currentPosition = transform.position;
        if(currentPosition.x+radiusOfCollider>ScreenUnits.ScreenRight)
        {
            currentPosition.x = ScreenUnits.ScreenLeft - radiusOfCollider;
        }
        else if(currentPosition.y-radiusOfCollider>ScreenUnits.ScreenTop)
        {
            currentPosition.y = ScreenUnits.ScreenBottom - radiusOfCollider;
        }
        else if(currentPosition.y+radiusOfCollider<ScreenUnits.ScreenBottom)
        {
            currentPosition.y = ScreenUnits.ScreenTop + radiusOfCollider;
        }
        else if(currentPosition.x-radiusOfCollider<ScreenUnits.ScreenLeft)
        {
            currentPosition.x = ScreenUnits.ScreenRight + radiusOfCollider;
        }
        transform.position = currentPosition;
    }

    private void Rotate()
    {
        float rotateInput = Input.GetAxis("Rotate");
        float rotateAmount = rotateDegreesPerSecond * Time.deltaTime;
        if(rotateInput<0)
        {
            rotateAmount *= -1;
            transform.Rotate(Vector3.forward, rotateAmount);
            Rotation();
        }
        else if(rotateInput>0)
        {
            transform.Rotate(Vector3.forward, rotateAmount);
            Rotation();
        }
    }

    private void Rotation()
    {
        float rotation = Mathf.Deg2Rad * (transform.eulerAngles.z + 90f);
        float x = Mathf.Cos(rotation);
        float y = Mathf.Sin(rotation);
        thrustDirection = new Vector2(x, y);
    }
    private void FixedUpdate()
    {
        Thrust();
    }

    private void Update()
    {
        Rotate();
    }
}
