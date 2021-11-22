using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public Vector3 spawnPos = new Vector3(0, 0, 30);

    void Start()
    {
        InvokeRepeating("SpawnObstacle", 0.5f, 5f); //usamos la función spawnobstacle, a los 0.5 segundos de darle a play y luego se vuelve a ejecutar cada 5 segundos.
    }

    public void SpawnObstacle()
    {
        float randomY = Random.Range(-10f, 10f); //generamos un número random
        spawnPos = new Vector3(0, randomY, spawnPos.z + 50f); //el nuevo obstáculo se generará a 50 metros del anterior y a una altura aleatoria
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
}
