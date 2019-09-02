using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class tillemanageer : MonoBehaviour

{
    public float safeZone = 100.0f;
    public GameObject[] tilePrefabs;
    private Transform playerTransform;
    private float spawnZ = 100.0f;
    private float tileLenght = 100.0f;
    private int amnTilesOnScreen = 7;
    private List<GameObject> activeTiles;
    private int lastPrefabIndex = 0;
    private void Start()
    {
        activeTiles = new List<GameObject>();
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        for (int i = 0; i < amnTilesOnScreen; i++)
        {
            SpawnTile();
        }
    }


    private void Update()
    {
        if (playerTransform.position.z - safeZone > (spawnZ - amnTilesOnScreen * tileLenght))
        {
            SpawnTile();
            DeleteTile();
        }
    }
    private void SpawnTile(int prefabIndex = -1)
    {
        GameObject go;
        go = Instantiate(tilePrefabs[RandomPrefabIndex()]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawnZ;
        spawnZ += tileLenght;
        activeTiles.Add(go);
    }
    private void DeleteTile()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }
    private int RandomPrefabIndex()
    {
        int randomIndex = lastPrefabIndex;
        while (randomIndex == lastPrefabIndex)
        {
            randomIndex = Random.Range(0, tilePrefabs.Length);
        }
        lastPrefabIndex = randomIndex;
        return randomIndex;
    }
}