using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField] Sprite[] sprites;
    Vector2 initialPos;
    const float rateOfForce = 3f;
    CircleCollider2D collider;
    float radiusOfCollider;
    // Start is called before the first frame update
    void Start()
    {
        InitialPos();
        InitialSprite();
        RandomDirection();
    }

    private void ScreenWrapping()
    {
        Vector2 currentPos = transform.position;
        if (currentPos.x < ScreenUtils.LeftScreen - radiusOfCollider)
            currentPos.x = ScreenUtils.RightScreen + radiusOfCollider;
        if (currentPos.x > ScreenUtils.RightScreen + radiusOfCollider)
            currentPos.x = ScreenUtils.LeftScreen - radiusOfCollider;
        if (currentPos.y < ScreenUtils.BottomScreen - radiusOfCollider)
            currentPos.y = ScreenUtils.TopScreen + radiusOfCollider;
        if (currentPos.y > ScreenUtils.TopScreen + radiusOfCollider)
            currentPos.y = ScreenUtils.BottomScreen - radiusOfCollider;
        transform.position = currentPos;
    }
    private void RandomDirection()
    {
        Rigidbody2D myRigid = GetComponent<Rigidbody2D>();
        float angle = Random.Range(0, 2 * Mathf.PI);
        Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        myRigid.AddForce(direction * rateOfForce, ForceMode2D.Impulse);
    }

    private void InitialSprite()
    {
        SpriteRenderer currentSprite = GetComponent<SpriteRenderer>();
        currentSprite.sprite = sprites[Random.Range(0, sprites.Length)];
    }
    private void InitialPos()
    {
        initialPos = new Vector2(Screen.width / 2, Screen.height / 2);
        Vector2 initialPosWorld = Camera.main.ScreenToWorldPoint(initialPos);
        transform.position = initialPosWorld;
    }

    // Update is called once per frame
    void Update()
    {
        ScreenWrapping();
    }
}
