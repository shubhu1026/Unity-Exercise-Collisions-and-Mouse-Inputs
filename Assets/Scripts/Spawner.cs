using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField]
    GameObject rockPrefab1;
    [SerializeField]
    GameObject rockPrefab2;

    //timer control
    Timer spawnTimer;

    //spawn control
    GameObject[] rockObjects;
   

//spawn location support
const int SpawnBorderSize = 100;
    int minSpawnX;
    int minSpawnY;
    int maxSpawnX;
    int maxSpawnY;

    // Start is called before the first frame update
    void Start()
    {
        //spawn boundaries
        minSpawnX = SpawnBorderSize;
        maxSpawnX = Screen.width - SpawnBorderSize;
        minSpawnY = SpawnBorderSize;
        maxSpawnY = Screen.height - SpawnBorderSize;

        rockObjects = GameObject.FindGameObjectsWithTag("Rock");
        //create and start the timer
        spawnTimer = gameObject.AddComponent<Timer>();
        spawnTimer.Duration = 1;
        spawnTimer.Run();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTimer.Finished) {

            if (rockObjects.Length < 3)
            {
                SpawnRock();
            }

            spawnTimer.Duration = 1;
            spawnTimer.Run();
        }
    }

    void SpawnRock()
    {
        Vector3 location = new Vector3(Random.Range(minSpawnX,maxSpawnX), 
            Random.Range(minSpawnY,maxSpawnY), 
            -Camera.main.transform.position.z);

        Vector3 worldLocation = Camera.main.ScreenToWorldPoint(location);

        int prefabNumber = Random.Range(0, 2);
        if (prefabNumber == 0)
        {
            Instantiate<GameObject>(rockPrefab1, worldLocation, Quaternion.identity);
        }
        else
        {
            Instantiate<GameObject>(rockPrefab2, worldLocation, Quaternion.identity);
        }
    }
}
