using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZone : MonoBehaviour
{
    public float xSize, ySize, zSize;
    private float spawnCD = 3f;
    public GameObject enemy;

    void OnDrawGizmos()
    {
        Gizmos.color = new Vector4(0, 1, 0, 0.5f);
        Gizmos.DrawCube(transform.position,
            new Vector3(xSize, ySize, zSize));
    }

    void Update()
    {
        spawnCD -= Time.deltaTime;
        if (spawnCD <= 0)
        {
            print("000");
            Instantiate(enemy, new Vector3(
                Random.Range(-xSize / 2, xSize / 2) + transform.position.x,
                Random.Range(-ySize / 2, ySize / 2) + transform.position.y,
                Random.Range(-zSize / 2, zSize / 2) + transform.position.z
            ), Quaternion.identity, transform);
            spawnCD = 3;
        }
    }

}
