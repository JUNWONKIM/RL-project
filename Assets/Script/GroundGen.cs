using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundGen: MonoBehaviour
{
    public GameObject tilePrefab; // Scale이 (0.1, 1, 0.1)인 Plane 프리팹
    public int width = 10;
    public int height = 10;

    void Start()
    {
        float tileSize = 1f; // 우리가 Plane을 1x1로 만들었으니까 1 유닛 간격

        for (int x = 0; x < width; x++)
        {
            for (int z = 0; z < height; z++)
            {
                Vector3 position = new Vector3(x * tileSize, 0f, z * tileSize);
                Instantiate(tilePrefab, position, Quaternion.identity, transform);
            }
        }
    }
}
