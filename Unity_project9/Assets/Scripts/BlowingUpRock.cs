using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlowingUpRock : MonoBehaviour
{
    [SerializeField] GameObject rockPrefab;
    [SerializeField] GameObject explosion;
    [SerializeField] Sprite greenRock;
    [SerializeField] Sprite whiteRock;
    [SerializeField] Sprite redRock;
    [SerializeField] Text greenRocks;
    [SerializeField] Text whiteRocks;
    [SerializeField] Text redRocks;
    List<GameObject> gameObjects = new List<GameObject>();
    GameControl game;
    //private void FindRocks()
    //{
    //    gameObjects.Clear();
    //    gameObjects.AddRange(Object.FindObjectsOfType<GameObject>());
    //}

    private void Start()
    {
        game = GetComponent<GameControl>();
    }
    private void Update()
    {
        //FindRocks();
        DifferenciateRocks();
    }

    private void DifferenciateRocks()
    {
        if (Input.GetAxis("BlowUpGreen") > 0)
        {
            BlowUpRocks(RockColor.green);
        }
        if (Input.GetAxis("BlowUpWhite") > 0)
        {
            BlowUpRocks(RockColor.white);
        }
        if (Input.GetAxis("BlowUpRed") > 0)
        {
            BlowUpRocks(RockColor.red);
        }
    }

    private void BlowUpRocks(RockColor color)
    {
        gameObjects.Clear();
        gameObjects.AddRange(GameObject.FindGameObjectsWithTag(color.ToString()));
        if(color==RockColor.green)
        {
            int current = game.TotalGreen(gameObjects.Count);
            greenRocks.text = current.ToString();
        }
        else if(color==RockColor.white)
        {
            int current = game.TotalWhite(gameObjects.Count);
            whiteRocks.text = current.ToString();
        }
        else if(color==RockColor.red)
        {
            int current = game.TotalRed(gameObjects.Count);
            redRocks.text = current.ToString();
        }
        for(int i=gameObjects.Count-1;i>=0;i--)
        {
            BlowUpRock(gameObjects[i]);
        }
    }

    private void BlowUpRock(GameObject gameObject)
    {
        Instantiate<GameObject>(explosion, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
