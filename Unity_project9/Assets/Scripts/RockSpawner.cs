using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    [SerializeField] GameObject rockPrefab;
    [SerializeField] Sprite[] rocks;
    Vector2 spawningPos;
    Vector2 worldSpawningPos;
    const float totalTime = 1f;
    Timer timer;
    private void Start()
    {
        timer = GetComponent<Timer>();
        spawningPos = new Vector2(Screen.width / 2, Screen.height / 2);
        worldSpawningPos = Camera.main.ScreenToWorldPoint(spawningPos);
        timer.Duration = totalTime;
        timer.Run();
    }

    private void SpawnRocks()
    {
        if(timer.Finished)
        {
            int currentSprite = Random.Range(0, rocks.Length);
            SpriteRenderer spriteRenderer = rockPrefab.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite= rocks[currentSprite];
            if(spriteRenderer.sprite==rocks[0])
            {
                rockPrefab.tag = RockColor.green.ToString();
            }
            else if(spriteRenderer.sprite==rocks[1])
            {
                rockPrefab.tag = RockColor.red.ToString();
            }
            else if(spriteRenderer.sprite==rocks[2])
            {
                rockPrefab.tag = RockColor.white.ToString();
            }
            GameObject myobject= Instantiate<GameObject>(rockPrefab) as GameObject;
            myobject.transform.position = worldSpawningPos;
            timer.Duration = totalTime;
            timer.Run();
        }
    }

    private void Update()
    {
        SpawnRocks();
    }
}
