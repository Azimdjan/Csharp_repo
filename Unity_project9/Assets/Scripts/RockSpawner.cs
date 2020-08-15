using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    [SerializeField] GameObject rockPrefab;
    [SerializeField] Sprite[] sprites;
    private SpriteRenderer sprite;
    private GameObject[] rocks;
    [SerializeField] int numberRocks;
    private bool isSpawning = false;
    Timer spawnTimer;
    const float spawnTime = 1f;
    private float spawnLocationX;
    private float spawnLocationY;
    private int option = 3;
    // Start is called before the first frame update
    private void Awake()
    {
        spawnTimer = gameObject.AddComponent<Timer>();
    }

    void Start()
    {
        Instantiating();
        SettingTimer();
        CreatingLocation();
    }

    private void SettingTimer()
    {
        spawnTimer.Duration = spawnTime;
        spawnTimer.Run();
    }

    private void Instantiating()
    {
        rocks = GameObject.FindGameObjectsWithTag("Rock");
        numberRocks = rocks.Length;
    }

    private void CreatingLocation()
    {
        spawnLocationX = Screen.width / 2;
        spawnLocationY = Screen.height / 2;
    }

    private void SpawningRocks()
    {
        Vector2 location = new Vector2(spawnLocationX, spawnLocationY);
        Vector2 worldLocation = Camera.main.ScreenToWorldPoint(location);
        ChangingSprite();
        GameObject currentRock = Instantiate<GameObject>(rockPrefab) as GameObject;
        currentRock.transform.position = worldLocation;
    }

    private void ChangingSprite()
    {
        int currentSprite = Random.Range(0, option);
        rockPrefab.GetComponent<SpriteRenderer>().sprite = sprites[currentSprite];
    }

    private void SpawningWithDelay()
    {
        if(spawnTimer.Finished&&numberRocks<3)
        {
            SpawningRocks();
            spawnTimer.Duration = spawnTime;
            spawnTimer.Run();
        }
    }
    // Update is called once per frame
    void Update()
    {
        Instantiating();
        SpawningWithDelay();
    }
}
