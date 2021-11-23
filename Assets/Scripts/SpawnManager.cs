using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public Vector3 spawnPos = new Vector3(0, 0, 30);
    private float TimeFirstSpawn = 0.5f;
    private float TimeSpawn = 5f;

    void Start()
    {
        InvokeRepeating("SpawnObstacle", TimeFirstSpawn, TimeSpawn); //usamos la función spawnobstacle, a los 0.5 segundos de darle a play y luego se vuelve a ejecutar cada 5 segundos.
    }

    public void SpawnObstacle()
    {
        float randomY = Random.Range(-10f, 10f); //generamos un número random entre -10 y 10
        spawnPos = new Vector3(0, randomY, spawnPos.z + 50f); //La posición de cada obstáculo queremos que sea 50 metros más alante que el anterior y a una altura aleatoria entre -10 y 10

        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation); //esta función generará el prefab en la posición spawnPose y con la rotación que ya tiene el prefab
    }
}
