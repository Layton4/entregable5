using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(0, 0, 30);
    private float TimeFirstSpawn = 0.5f;
    private float TimeSpawn = 5f;

    void Start()
    {

        InvokeRepeating("SpawnObstacle", TimeFirstSpawn, TimeSpawn); //usamos la función spawnobstacle, a los 0.5 segundos de darle a play y luego se vuelve a ejecutar cada 5 segundos.

    }
    public void SpawnObstacle()
    {
        float randomY = Random.Range(-10f, 10f); //generamos un número random entre -10 y 10 para la coordenada y
        spawnPos = new Vector3(0, randomY, spawnPos.z + 50f); //el nuevo obstáculo se generará a 50 metros del anterior y a una altura aleatoria

        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation); //generar el prefab, en las coordenadas spawnPos y con la rotación que ya tiene el prefab
    }
}
