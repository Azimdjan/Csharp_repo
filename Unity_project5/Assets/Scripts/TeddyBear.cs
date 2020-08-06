using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeddyBear : MonoBehaviour
{
    Rigidbody2D myrigidbody2d;
    const float MINSPEED = 2F;
    const float MAXSPEED = 5F;
    void Start()
    {
        myrigidbody2d = GetComponent<Rigidbody2D>();
        float angle = Random.Range(0, 2 * Mathf.PI);
        Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        float speed = Random.Range(MINSPEED, MAXSPEED);
        myrigidbody2d.AddForce(direction * speed, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("ouch");
    }
}
