using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;

    public float radiusSpawner;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("randomPositionSpawnPrefab",0,0.2f);    
    }


    void randomPositionSpawnPrefab()
    {
        GameObject obj = Instantiate(prefab);
        Vector2 pos = Random.insideUnitCircle;
        pos *= radiusSpawner;
        obj.transform.position = new Vector3(pos.x,0,pos.y);
        float y = transform.position.y;
    }
}
