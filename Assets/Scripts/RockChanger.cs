using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockChanger : MonoBehaviour
{
    [SerializeField]
    GameObject rockPrefab1; 
    [SerializeField]
    GameObject rockPrefab2; 
    [SerializeField]
    GameObject rockPrefab3;

    GameObject currentRock;
    // Start is called before the first frame update
    void Start()
    {
        currentRock = Instantiate<GameObject>(
            rockPrefab1, 
            Vector3.zero,
            Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        //change rock prefab on left mouse button click
        if (Input.GetMouseButtonDown(0))
        {

            if (Input.GetMouseButtonDown(0))
            {
                Vector3 position = Input.mousePosition;
                position.z = -Camera.main.transform.position.z;
                position = Camera.main.ScreenToWorldPoint(position);

                currentRock.transform.position = position;
            }
            ////first save the position and destroy current rock
            //Vector3 position = currentRock.transform.position;
            //Destroy(currentRock);

            ////instantiate new rock
            //int prefabNumber = Random.Range(0, 3);
            //if(prefabNumber == 0)
            //{
            //    currentRock = Instantiate<GameObject>(
            //    rockPrefab1,
            //    Vector3.zero,
            //    Quaternion.identity);
            //}
            //else if(prefabNumber == 1)
            //{
            //    currentRock = Instantiate<GameObject>(
            //    rockPrefab2,
            //    Vector3.zero,
            //    Quaternion.identity);
            //}
            //else
            //{
            //    currentRock = Instantiate<GameObject>(
            //    rockPrefab3,
            //    Vector3.zero,
            //    Quaternion.identity);
            //}
        }
    }
}
