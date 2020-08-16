using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CharacterChanger : MonoBehaviour
{
    [SerializeField] GameObject firstObject;
    [SerializeField] GameObject secondObject;
    [SerializeField] GameObject thirdObject;
    const int Max = 3;
    GameObject currentObject;
    // Start is called before the first frame update
    void Start()
    {
        currentObject = Instantiate<GameObject>(firstObject,transform.position,Quaternion.identity) as GameObject;
    }

    private void ChangePrefab()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 currentPosition = currentObject.transform.position;
            Destroy(currentObject);
            int currentPrefab = Random.Range(0, Max);
            if (currentPrefab == 0)
            {
                currentObject = Instantiate<GameObject>(firstObject, currentPosition, Quaternion.identity) as GameObject;
            }
            else if (currentPrefab == 1)
            {
                currentObject = Instantiate<GameObject>(secondObject, currentPosition, Quaternion.identity) as GameObject;
            }
            else if (currentPrefab == 2)
            {
                currentObject = Instantiate<GameObject>(thirdObject, currentPosition, Quaternion.identity) as GameObject;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        ChangePrefab();
    }
}
