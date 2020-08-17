using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Processes mouse button inputs
/// </summary>
public class MouseButtonProcessor : MonoBehaviour
{
    [SerializeField]
    GameObject prefabExplosion;
    [SerializeField]
    GameObject prefabTeddyBear;

    // first frame input support
    bool spawnInputOnPreviousFrame = false;
	bool explodeInputOnPreviousFrame = false;


    private Vector2 FindMousePosition
    {
        get
        {
            Vector2 mousePositionScreen = Input.mousePosition;
            Vector2 mousePositionWorld = Camera.main.ScreenToWorldPoint(mousePositionScreen);
            return mousePositionWorld; 
        }
    }
    private void SpawnTeddyBears()
    {
        if(Input.GetAxis("SpawnTeddyBears")>0)
        {
            if(!spawnInputOnPreviousFrame)
            {
                spawnInputOnPreviousFrame = true;
                GameObject currentTeddy = Instantiate<GameObject>(prefabTeddyBear) as GameObject;
                currentTeddy.transform.position = FindMousePosition;
            }
        }
        else
        {
            spawnInputOnPreviousFrame = false;
        }
    }

    private void ExplodeTeddyBears()
    {
        GameObject randomTeddy = GameObject.FindWithTag("TeddyBear");
        if(randomTeddy&&Input.GetAxis("ExplodeTeddyBears") >0)
        {
            if (!explodeInputOnPreviousFrame)
            {
                explodeInputOnPreviousFrame = true;
                GameObject explosion = Instantiate<GameObject>(prefabExplosion) as GameObject;
                explosion.transform.position = randomTeddy.transform.position;
                Destroy(randomTeddy);
            }
        }
        else
        {
            explodeInputOnPreviousFrame = false;
            Debug.LogError("Do not have any teddy bears!");
        }
    }
	void Update()
	{
        // spawn teddy bear as appropriate
        SpawnTeddyBears();
        // explode teddy bear as appropriate
        ExplodeTeddyBears();
	}
}
