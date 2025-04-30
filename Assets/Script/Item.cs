using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public GameObject itemPrefab;
    public int fieldSize = 10;
    public int itemCount = 10;

    private HashSet<Vector2Int> usedPositions = new HashSet<Vector2Int>();

    void Start()
    {
        SpawnItems();
    }

    void SpawnItems()
    {
        int spawned = 0;

        while (spawned < itemCount)
        {
            Vector2Int pos = new Vector2Int(
                Random.Range(0, fieldSize),
                Random.Range(0, fieldSize)
            );

            if (usedPositions.Contains(pos)) continue;

            Vector3 spawnPos = new Vector3(pos.x, 0.5f, pos.y);  // 높이 조절
            Instantiate(itemPrefab, spawnPos, Quaternion.identity);
            usedPositions.Add(pos);
            spawned++;
        }
    }
}
