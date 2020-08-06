using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    Rigidbody2D myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        Vector2 speed = new Vector2(1, 2);
        myRigidbody.AddForce(speed, ForceMode2D.Impulse);
    }
}
