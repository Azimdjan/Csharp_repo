using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    Rigidbody2D myrigidBody;
    const float MinSpeed = 1f;
    const float MaxSpeed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        myrigidBody = GetComponent<Rigidbody2D>();
        float angle = Random.Range(0.2f, Mathf.PI);
        float magnitude = Random.Range(MinSpeed, MaxSpeed);
        Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        myrigidBody.AddForce(direction * magnitude, ForceMode2D.Impulse);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
